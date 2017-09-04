<Query Kind="Program" />

// For convenience, you can include combination members within an enum declaration itself:

[Flags]
public enum BorderSides
{
	None=0,
	Left=1, Right=2, Top=4, Bottom=8,
	LeftRight = Left | Right, 
	TopBottom = Top  | Bottom,
	All       = LeftRight | TopBottom
}

static void Main()
{
	BorderSides.All.Dump();
	
	// The bitwise, arithmetic, and comparison operators return the result of processing
	// the underlying integral values:	
	(BorderSides.All ^ BorderSides.LeftRight).Dump();
}