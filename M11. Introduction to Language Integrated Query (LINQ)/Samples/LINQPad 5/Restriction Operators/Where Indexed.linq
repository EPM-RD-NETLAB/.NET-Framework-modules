<Query Kind="Statements" />

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
	  
var shortDigits = digits.Where((digit, index) => digit.Length < index); 
	  
Console.WriteLine("Short digits:"); 
foreach (var d in shortDigits) 
{ 
	Console.WriteLine("The word {0} is shorter than its value.", d); 
}