<Query Kind="Statements" />

string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
var reversedIDigits = ( 
		from d in digits 
		where d[1] == 'i' 
		select d) 
		.Reverse(); 
  
Console.WriteLine("A backwards list of the digits with a second character of 'i':"); 
foreach (var d in reversedIDigits) 
{ 
	Console.WriteLine(d); 
} 