<Query Kind="Statements" />

object[] numbers = { 2.4,  1.0, null, -5.6, "two", 3, "four", 5, "six", 7.0 }; 
  
var doubles = numbers.Cast<double>(); 
  
Console.WriteLine("Numbers stored as doubles:"); 
foreach (var d in doubles) 
{ 
	Console.WriteLine(d); 
} 