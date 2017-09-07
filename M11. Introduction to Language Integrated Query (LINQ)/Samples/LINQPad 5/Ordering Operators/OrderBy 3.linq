<Query Kind="Program" />

void Main()
{
	string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 
	  
	var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer()); 
	  
	sortedWords.Dump("Sorted words:");
	  
}

public class CaseInsensitiveComparer : IComparer<string> 
{ 
	public int Compare(string x, string y) 
	{ 
		return string.Compare(x, y, StringComparison.OrdinalIgnoreCase); 
	} 
}