<Query Kind="Program" />

// The content of a value type variable or constant is simply a value. 
// You can define a custom value type with the struct keyword:

public struct Point { public int X, Y; }

static void Main()
{
	Point p1 = new Point();
	p1.X = 7;
	
	Point p2 = p1;             // Assignment causes copy
	
	Console.WriteLine (p1.X);  // 7
	Console.WriteLine (p2.X);  // 7
	
	p1.X = 9;                  // Change p1.X
	
	Console.WriteLine (p1.X);  // 9
	Console.WriteLine (p2.X);  // 7
}