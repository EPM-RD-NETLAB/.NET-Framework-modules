<Query Kind="Statements" />

var numbers = 		
		from n in Enumerable.Range(100, 50) 
  		select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" }; 
		
numbers.Dump(); 

foreach (var n in numbers) 
{ 
	Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven); 
} 