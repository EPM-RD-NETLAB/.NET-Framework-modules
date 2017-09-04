<Query Kind="Program" />

// The instance field Name pertains to an instance of a particular Panda,
// whereas Population pertains to the set of all Pandas:

public class Panda
{
	public string Name;             // Instance field
	public static int Population;   // Static field

	public Panda (string n)         // Constructor
	{
		Name = n;                      // Assign the instance field
		Population = Population + 1;   // Increment the static Population field
	}
}

static void Main()
{
	Panda p1 = new Panda ("Pan Dee");
	Panda p2 = new Panda ("Pan Dah");

	Console.WriteLine (p1.Name);      // Pan Dee
	Console.WriteLine (p2.Name);      // Pan Dah

	Console.WriteLine (Panda.Population);   // 2
}