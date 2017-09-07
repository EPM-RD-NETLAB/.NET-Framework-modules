<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
var digitOddEvens = from n in numbers 
					select new { Digit = strings[n], Even = (n % 2 == 0) }; 
  
foreach (var d in digitOddEvens) 
{ 
	Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd"); 
}