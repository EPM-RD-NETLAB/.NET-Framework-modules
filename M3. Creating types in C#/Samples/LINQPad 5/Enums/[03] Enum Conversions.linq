<Query Kind="Program" />

public enum BorderSide { Left, Right, Top, Bottom }

public enum HorizontalAlignment
{
	Left = BorderSide.Left,
	Right = BorderSide.Right,
	Center
}

static void Main()
{
	// You can convert an enum instance to and from its underlying integral value with an explicit cast:
	
	int i = (int) BorderSide.Left;
	i.Dump ("i");
	
	BorderSide side = (BorderSide) i;
	side.Dump ("side");
	
	bool leftOrRight = (int) side <= 2;
	leftOrRight.Dump ("leftOrRight");
	
	HorizontalAlignment h = (HorizontalAlignment) BorderSide.Right;
	h.Dump ("h");
	
	BorderSide b = 0;    // No cast required with the 0 literal.
	b.Dump ("b");
}
