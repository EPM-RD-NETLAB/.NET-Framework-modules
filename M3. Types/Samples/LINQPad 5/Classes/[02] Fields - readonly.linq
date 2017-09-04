<Query Kind="Program" />

// Readonly fields let you create *immutable* classes.

class Octopus
{
	public readonly string Name;
	public readonly int Legs = 8;
	
	public Octopus (string name)
	{
		Name = name;
	}
}

static void Main()
{
	var o = new Octopus ("Jack");
	o.Name.Dump();	
	o.Legs = 20;	// Compile-time error
}