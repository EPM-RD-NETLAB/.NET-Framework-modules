<Query Kind="Statements" />

string[] words = { "cherry", "apple", "blueberry" }; 

int shortestWord = words.Min(w => w.Length); 
  
Console.WriteLine("The shortest word is {0} characters long.", shortestWord);