<Query Kind="Program" />

void Main()
{
	string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " }; 
	  
		var orderGroups = anagrams.GroupBy( 
					w => w.Trim(), 
					a => a.ToUpper(), 
					new AnagramEqualityComparer() 
					); 
		  
	orderGroups.Dump(); 
} 

public class AnagramEqualityComparer : IEqualityComparer<string> 
{ 
	public bool Equals(string x, string y) 
	{ 
		return getCanonicalString(x) == getCanonicalString(y); 
	} 
		  
	public int GetHashCode(string obj) 
	{ 
		return getCanonicalString(obj).GetHashCode(); 
	} 
		  
	private string getCanonicalString(string word) 
	{ 
		char[] wordChars = word.ToCharArray(); 
		Array.Sort<char>(wordChars); 
		return new string(wordChars); 
	} 
} 
