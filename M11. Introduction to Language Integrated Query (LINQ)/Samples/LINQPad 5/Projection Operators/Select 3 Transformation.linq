<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
var textNums = 	from n in numbers 
				select strings[n]; 
  
Console.WriteLine("Number strings:"); 
foreach (var s in textNums) 
	Console.WriteLine(s); 