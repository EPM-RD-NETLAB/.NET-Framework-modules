<Query Kind="Program" />

// A field is a variable that is a member of a class or struct.

class Octopus
{
	string name;
	public int Age = 10;
	static readonly int legs = 8, eyes = 1;
}

static void Main()
{
	var o = new Octopus();
	o.Age.Dump();	
}