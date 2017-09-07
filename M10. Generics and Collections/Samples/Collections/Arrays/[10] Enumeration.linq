<Query Kind="Statements">
  
</Query>

int[] myArray = { 1, 2, 3};
foreach (int val in myArray)
	Console.WriteLine (val);

// Alternative:
Array.ForEach (new[] { 1, 2, 3 }, Console.WriteLine);