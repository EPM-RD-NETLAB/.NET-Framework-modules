<Query Kind="Program" />

// For arrays, when the element type is a value type, each element value is allocated as part of the array:

public struct Point { public int X, Y; }

static void Main()
{
	Point[] a = new Point[1000];
	int x = a[500].X;                // 0
	x.Dump();
}