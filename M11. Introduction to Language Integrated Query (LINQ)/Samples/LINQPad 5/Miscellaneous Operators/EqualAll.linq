<Query Kind="Statements" />

var wordsA = new string[] { "cherry", "apple", "blueberry" }; 
var wordsB = new string[] { "cherry", "apple", "blueberry" }; 
  
bool match = wordsA.SequenceEqual(wordsB).Dump("The sequences match: "); 