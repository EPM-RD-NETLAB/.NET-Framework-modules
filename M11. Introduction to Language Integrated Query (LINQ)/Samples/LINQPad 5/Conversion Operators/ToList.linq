<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 
  
var sortedWords = 
		from w in words 
		orderby w 
		select w; 
var wordList = sortedWords.ToList(); 
  
Console.WriteLine("The sorted word list:"); 
foreach (var w in wordList) 
{ 
	Console.WriteLine(w); 
} 