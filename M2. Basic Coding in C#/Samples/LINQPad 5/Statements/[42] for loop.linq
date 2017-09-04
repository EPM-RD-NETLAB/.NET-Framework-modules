<Query Kind="Statements" />

// Simple for-loop:

for (int i = 0; i < 3; i++)
	Console.WriteLine (i);
	
Console.WriteLine();
	
// You can have more than one variable in the initialization clause:

for (int i = 0, prevFib = 1, curFib = 1; i < 10; i++)
{
	Console.WriteLine (prevFib);
	int newFib = prevFib + curFib;
  	prevFib = curFib; curFib = newFib;
}