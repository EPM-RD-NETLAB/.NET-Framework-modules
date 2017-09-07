<Query Kind="Statements">
  
</Query>

var d = new Dictionary<string, int>();

d.Add("One", 1);
d["Two"] = 2;     // adds to dictionary because "two" not already present
d["Two"] = 22;    // updates dictionary because "two" is now present
d["Three"] = 3;

Console.WriteLine (d["Two"]);                // Prints "22"
Console.WriteLine (d.ContainsKey ("One"));   // true (fast operation)
Console.WriteLine (d.ContainsValue (3));     // true (slow operation)
int val = 0;
if (!d.TryGetValue ("onE", out val))
	Console.WriteLine ("No val");            // "No val" (case sensitive)

// Three different ways to enumerate the dictionary:

foreach (KeyValuePair<string, int> kv in d)          //  One ; 1
	Console.WriteLine (kv.Key + "; " + kv.Value);    //  Two ; 22
                                                     //  Three ; 3

foreach (string s in d.Keys) Console.Write (s);      // OneTwoThree
Console.WriteLine();
foreach (int i in d.Values) Console.Write (i);       // 1223

var dIgnoreCase = new Dictionary<string, bool> (StringComparer.OrdinalIgnoreCase);
dIgnoreCase["foo"] = true;
dIgnoreCase["FOO"].Dump();