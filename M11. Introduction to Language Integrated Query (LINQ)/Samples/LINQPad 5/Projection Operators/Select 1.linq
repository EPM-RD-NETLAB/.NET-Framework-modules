<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
  
var numsPlusOne = 	from n in numbers select n + 1; 
  
Console.WriteLine("Numbers + 1:"); 
foreach (var i in numsPlusOne) 
{ 
	Console.WriteLine(i); 
} 