<Query Kind="Program" />

// You can combine enum members. To prevent ambiguities, members of a combinable enum require
// explicitly assigned values, typically in powers of two:

[Flags]
public enum BorderSides { None=0, Left=1, Right=2, Top=4, Bottom=8 }

static void Main()
{
	BorderSides leftRight = BorderSides.Left | BorderSides.Right;
	
	if ((leftRight & BorderSides.Left) != 0)
		Console.WriteLine ("Includes Left");   // Includes Left
	
	string formatted = leftRight.ToString();   // "Left, Right"
	
	BorderSides s = BorderSides.Left;
	s |= BorderSides.Right;
	Console.WriteLine (s == leftRight);   // True
	
	s ^= BorderSides.Right;               // Toggles BorderSides.Right
	Console.WriteLine (s);                // Left
}