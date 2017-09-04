<Query Kind="Program" />

public enum BorderSide { Left, Right, Top, Bottom }

static void Main()
{
	// Since an enum can be cast to and from its underlying integral type, the actual value
	// it may have may fall outside the bounds of a legal enum member:
	BorderSide b = (BorderSide) 12345;
	Console.WriteLine (b);                // 12345
	
	BorderSide b2 = BorderSide.Bottom;
	b2++;									// No errors
	Console.WriteLine (b2);					// 4 (illegal value)
}

// An invalid BorderSide would break the following method:

void Draw (BorderSide side)
{
	if      (side == BorderSide.Left)  { /*...*/ }
	else if (side == BorderSide.Right) { /*...*/ }
	else if (side == BorderSide.Top)   { /*...*/ }
	else                               { /*...*/ }  // Assume BorderSide.Bottom
}