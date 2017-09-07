<Query Kind="Program" />

static IEnumerable<string> ReadLines(Func<TextReader> provider) 
{
	using (TextReader reader = provider()) 
	{
		string line;
		while ((line = reader.ReadLine()) != null)
		{
   			yield return line;
		}
	}
}

static IEnumerable<string> ReadLines(string filename)
{
   return ReadLines(filename, Encoding.UTF8);
}

static IEnumerable<string> ReadLines(string filename, Encoding encoding) 
{
   return ReadLines(() => new StreamReader(filename, encoding));
}

void Main()
{
	string path = @"Z:\MIB On My Mac\Desktop\LINQPadQueries for training\LINQPadQueries.Iterator\text.txt";

	foreach (var s in ReadLines(() => File.OpenText(path)))//!!!!!!!
		Console.WriteLine(s);

	foreach (var s in ReadLines(path, Encoding.UTF7))
			Console.WriteLine(s);
}