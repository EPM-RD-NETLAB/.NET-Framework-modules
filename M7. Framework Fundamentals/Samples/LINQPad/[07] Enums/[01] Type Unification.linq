<Query Kind="Program" />

// See also Enums in Chapter 3

enum Nut  { Walnut, Hazelnut, Macadamia }
enum Size { Small, Medium, Large }

static void Main()
{
	Display (Nut.Macadamia);     // Nut.Macadamia
	Display (Size.Large);        // Size.Large
}

static void Display (Enum value)		// The Enum type unifies all enums
{
	Console.WriteLine (value.GetType().Name + "." + value.ToString());
}