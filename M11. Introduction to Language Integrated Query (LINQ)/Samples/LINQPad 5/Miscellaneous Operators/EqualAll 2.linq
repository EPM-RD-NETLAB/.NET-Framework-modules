<Query Kind="Program" />

void Main()
{
	var wordsA = new string[] { "apple", "blueberry", "cherry" }; 
	var wordsB = new string[] { "APple", "blueberry", "CHerry" }; 
	  
	bool match = wordsA.SequenceEqual(wordsB, new CaseInsensitiveComparer()).Dump("The sequences match: "); 
}

public class CaseInsensitiveComparer : IEqualityComparer<string> 
{ 
	public bool Equals(string x, string y) 
	{ 
		return string.Compare(x, y, StringComparison.OrdinalIgnoreCase) == 0; 
	} 
	
	public int GetHashCode(string obj) 
	{ 
		return obj.GetHashCode(); 
	} 
}

