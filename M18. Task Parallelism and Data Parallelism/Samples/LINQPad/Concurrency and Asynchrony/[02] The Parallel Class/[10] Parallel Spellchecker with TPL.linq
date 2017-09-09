<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

string wordLookupFile = Path.Combine (Path.GetTempPath(), "WordLookup.txt");

if (!File.Exists (wordLookupFile))    // Contains about 150,000 words
	new WebClient().DownloadFile (
		"http://www.albahari.com/ispell/allwords.txt", wordLookupFile);

var wordLookup = new HashSet<string> (
	File.ReadAllLines (wordLookupFile),
	StringComparer.InvariantCultureIgnoreCase);

var random = new Random();
string[] wordList = wordLookup.ToArray();

string[] wordsToTest = Enumerable.Range (0, 1000000)
	.Select (i => wordList [random.Next (0, wordList.Length)])
	.ToArray();

wordsToTest [12345] = "woozsh";     // Introduce a couple
wordsToTest [23456] = "wubsie";     // of spelling mistakes.

var misspellings = new ConcurrentBag<Tuple<int,string>>();

Parallel.ForEach (wordsToTest, (word, state, i) =>
{
	if (!wordLookup.Contains (word))
		misspellings.Add (Tuple.Create ((int) i, word));
});

misspellings.Dump();