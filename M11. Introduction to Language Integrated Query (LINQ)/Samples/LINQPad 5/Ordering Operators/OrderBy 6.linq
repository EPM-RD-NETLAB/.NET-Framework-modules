<Query Kind="Statements" />

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
var sortedDigits = 
		from d in digits 
		orderby d.Length, d 
		select d; 
  
Console.WriteLine("Sorted digits:"); 
foreach (var d in sortedDigits) 
{ 
	Console.WriteLine(d); 
} 