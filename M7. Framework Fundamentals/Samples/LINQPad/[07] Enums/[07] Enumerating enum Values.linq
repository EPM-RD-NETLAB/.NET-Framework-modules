<Query Kind="Program" />

[Flags] public enum BorderSides { Left=1, Right=2, Top=4, Bottom=8 }

static void Main()
{
	foreach (Enum value in Enum.GetValues (typeof (BorderSides)))
		Console.WriteLine (value);
}

