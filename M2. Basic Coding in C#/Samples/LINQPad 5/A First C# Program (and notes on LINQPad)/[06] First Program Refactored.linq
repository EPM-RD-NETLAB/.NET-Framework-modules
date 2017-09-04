<Query Kind="Program" />

// Here, we've refactored the logic in our original main method into a method called FeetToInches.
// (We have to go back to 'Program' mode for this.)

static void Main()
{
	Console.WriteLine (FeetToInches (30));      // 360
	Console.WriteLine (FeetToInches (100));     // 1200
}

static int FeetToInches (int feet)
{
	int inches = feet * 12;
	return inches;
}