<Query Kind="Program" />

// Changing the following struct to a class makes the type legal:

public struct Point
{
	int x = 1;								// Illegal: cannot initialize field
	int y;
	public Point() { }						// Illegal: cannot have parameterless constructor	
	public Point (int x) { this.x = x; }	// Illegal: must assign field y
}

static void Main() { }