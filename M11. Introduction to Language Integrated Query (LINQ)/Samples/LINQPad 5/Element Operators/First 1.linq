<Query Kind="Statements" />

string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
string startsWithO = strings.First(s => s[0] == 'o'); 
  
Console.WriteLine("A string starting with 'o': {0}", startsWithO);