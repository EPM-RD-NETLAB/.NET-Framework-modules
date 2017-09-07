<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 
  
int totalChars = words.Sum(w => w.Length); 
  
Console.WriteLine("There are a total of {0} characters in these words.", totalChars);