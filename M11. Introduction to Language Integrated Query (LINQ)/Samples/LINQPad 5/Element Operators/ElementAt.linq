<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
  
int fourthLowNum = ( 
		from n in numbers 
		where n > 5 
		select n).ElementAt(1);  // second number is index 1 because sequences use 0-based indexing 
 
Console.WriteLine("Second number > 5: {0}", fourthLowNum); 