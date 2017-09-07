<Query Kind="Statements" />

string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" }; 
	  
var wordGroups = 
			from w in words 
			group w by w[0] into g 
			select new { FirstLetter = g.Key, Words = g }; 
wordGroups.Dump();

foreach (var g in wordGroups) 
{ 
	Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter); 
	foreach (var w in g.Words) 
	{ 
		Console.WriteLine(w); 
	} 
} 