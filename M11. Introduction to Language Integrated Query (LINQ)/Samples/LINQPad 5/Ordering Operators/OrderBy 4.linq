<Query Kind="Statements" />

double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 }; 
  
var sortedDoubles = 
		from d in doubles 
		orderby d descending 
		select d; 
  
Console.WriteLine("The doubles from highest to lowest:"); 
foreach (var d in sortedDoubles) 
{ 
	Console.WriteLine(d); 
} 