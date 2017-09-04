<Query Kind="Program" />

// A value type cannot ordinarily have a null value:

public struct Point { public int X, Y; }

static void Main()
{
	Point p = null;		// This line will not compile.
	int x = null;		// Illegal, too.
}

// See "Nullable Types" in Chapter 4 for a workaround.