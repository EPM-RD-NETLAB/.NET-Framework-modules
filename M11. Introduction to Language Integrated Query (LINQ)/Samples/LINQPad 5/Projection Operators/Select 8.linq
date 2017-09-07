<Query Kind="Statements" />

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
int[] numbersB = { 1, 3, 5, 7, 8 }; 
  
var pairs = 
		from a in numbersA 
		from b in numbersB 
		where a < b 
		select new { a, b }; 
  
Console.WriteLine("Pairs where a < b:"); 
foreach (var pair in pairs) 
{ 
	Console.WriteLine("{0} is less than {1}", pair.a, pair.b); 
} 