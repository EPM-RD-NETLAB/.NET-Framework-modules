<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 
  
var sortedWords = 
		from w in words 
		orderby w.Length 
		select w; 
  
Console.WriteLine("The sorted list of words (by length):"); 
foreach (var w in sortedWords) 
{ 
	Console.WriteLine(w); 
}