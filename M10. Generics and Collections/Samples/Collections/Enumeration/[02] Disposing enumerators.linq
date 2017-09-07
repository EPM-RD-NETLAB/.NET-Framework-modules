<Query Kind="Statements">
  
</Query>

IEnumerable<char> s = "Hello";

using (var rator = s.GetEnumerator())
	while (rator.MoveNext())
	{
		char c = (char) rator.Current;
		Console.Write (c + ".");
	}

