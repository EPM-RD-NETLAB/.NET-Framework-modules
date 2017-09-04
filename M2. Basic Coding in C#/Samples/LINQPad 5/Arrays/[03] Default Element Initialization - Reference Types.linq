<Query Kind="Program" />

// In contrast, creating an array of reference types allocates null references:

public class Point { public int X, Y; }

static void Main()
{
	Point[] a = new Point[1000];
	
	for (int i = 0; i < a.Length; i++)		// Iterate i from 0 to 999
		a[i] = new Point();					// Set array element i with new point
		
	Point[] nulls = new Point[1000];
	Console.WriteLine (nulls[0] == null);	// True
	Console.WriteLine (nulls[0].X);			// Error: NullReferenceException thrown
}