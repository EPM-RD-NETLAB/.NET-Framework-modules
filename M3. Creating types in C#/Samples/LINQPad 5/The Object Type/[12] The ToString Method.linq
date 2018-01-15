<Query Kind="Program" />

// The ToString method is defined on System.Object and returns the default textual representation
// of a type instance:

static void Main()
{
	int x = 1;
	string s = x.ToString();     // s is "1"
	
	Panda p = new Panda { Name = "Petey" };
	Console.WriteLine (p.ToString()); 		// Petey
}

// You can override the ToString method on custom types:

public class Panda
{
	public string Name;
	public override string ToString() { return Name; }
}
