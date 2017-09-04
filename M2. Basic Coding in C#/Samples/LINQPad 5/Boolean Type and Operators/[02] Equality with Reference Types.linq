<Query Kind="Program" />

// For reference types, equality, by default, is based on reference, as opposed to the 
// actual value of the underlying object (more on this in Chapter 6).

static void Main()
{
	Dude d1 = new Dude ("John");
	Dude d2 = new Dude ("John");
	Console.WriteLine (d1 == d2);       // False
	Dude d3 = d1;
	Console.WriteLine (d1 == d3);       // True
}

public class Dude
{
	public string Name;
	public Dude (string n) { Name = n; }
}

