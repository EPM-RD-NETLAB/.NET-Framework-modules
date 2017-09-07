<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 
  
var sortedWords = 
		from w in words 
		orderby w 
		select w; 
  
Console.WriteLine("The sorted list of words:"); 
foreach (var w in sortedWords) 
{ 
	Console.WriteLine(w); 
} 
