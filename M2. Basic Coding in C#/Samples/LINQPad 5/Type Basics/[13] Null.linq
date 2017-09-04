<Query Kind="Program" />

// A reference can be assigned the literal null, indicating that the reference points to nothing:

public class Point { public int X, Y; }

static void Main()
{
	Point p = null;
	Console.WriteLine (p == null);   // True
	
	// The following line generates a runtime error (a NullReferenceException is thrown):
	Console.WriteLine (p.X);
}