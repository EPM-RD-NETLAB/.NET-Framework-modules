<Query Kind="Program" />

// All types in C# are represented at runtime with an instance of System.Type.
// There are two basic ways to get a System.Type object:
//  • Call GetType on the instance.
//  • Use the typeof operator on a type name.

static void Main()
{
	Point p = new Point();
	Console.WriteLine (p.GetType().Name);             // Point
	Console.WriteLine (typeof (Point).Name);          // Point
	Console.WriteLine (p.GetType() == typeof(Point)); // True
	Console.WriteLine (p.X.GetType().Name);           // Int32
	Console.WriteLine (p.Y.GetType().FullName);       // System.Int32
}

public class Point { public int X, Y; }
