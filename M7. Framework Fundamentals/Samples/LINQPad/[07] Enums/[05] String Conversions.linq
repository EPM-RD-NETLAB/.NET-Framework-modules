<Query Kind="Program" />

[Flags] public enum BorderSides { Left=1, Right=2, Top=4, Bottom=8 }

static void Main()
{
	// To string:
	BorderSides.Right.ToString().Dump();
	Enum.Format (typeof (BorderSides), BorderSides.Right, "g").Dump();
	
	// From string:
	BorderSides leftRight = (BorderSides) Enum.Parse (typeof (BorderSides), "Left, Right");
	leftRight.Dump();
	
	BorderSides leftRightCaseInsensitive = (BorderSides) 
		Enum.Parse (typeof (BorderSides), "left, right", true);
		
	leftRightCaseInsensitive.Dump();

}

