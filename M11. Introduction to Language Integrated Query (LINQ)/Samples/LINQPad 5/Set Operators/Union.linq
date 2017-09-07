<Query Kind="Statements" />

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
int[] numbersB = { 1, 2, 3, 5, 7, 8 }; 
  
var uniqueNumbers = numbersA.Union(numbersB).OrderBy(x => x); 
  
Console.WriteLine("Unique numbers from both arrays:"); 
foreach (var n in uniqueNumbers) 
{ 
	Console.WriteLine(n); 
} 