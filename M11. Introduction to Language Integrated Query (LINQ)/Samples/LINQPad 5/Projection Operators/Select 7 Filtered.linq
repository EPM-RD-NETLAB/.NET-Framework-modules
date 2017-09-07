<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
var lowNums = 
		from n in numbers 
		where n < 5 
		select digits[n]; 
  
Console.WriteLine("Numbers < 5:"); 
foreach (var num in lowNums) 
{ 
	Console.WriteLine(num); 
}