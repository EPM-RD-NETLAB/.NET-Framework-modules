<Query Kind="Statements" />

// An empty string has a length of zero:
string empty = "";
Console.WriteLine (empty == "");              // True
Console.WriteLine (empty == string.Empty);    // True
Console.WriteLine (empty.Length == 0);        // True

//Because strings are reference types, they can also be null:
string nullString = null;
Console.WriteLine (nullString == null);        // True
Console.WriteLine (nullString == "");          // False
Console.WriteLine (string.IsNullOrEmpty (nullString));	// True
Console.WriteLine (nullString.Length == 0);             // NullReferenceException