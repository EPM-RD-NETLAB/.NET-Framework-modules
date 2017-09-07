<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 
  
double averageLength = words.Average(w => w.Length); 
  
Console.WriteLine("The average word length is {0} characters.", averageLength);