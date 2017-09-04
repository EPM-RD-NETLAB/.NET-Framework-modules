<Query Kind="Program" />

// The out modifier is most commonly used to get multiple return values back from a method:

static void Split (string name, out string firstNames, out string lastName)
{
	int i = name.LastIndexOf (' ');
	firstNames = name.Substring (0, i);
	lastName   = name.Substring (i + 1);
}
	
static void Main()
{
	string a, b;
	Split ("Stevie Ray Vaughn", out a, out b);
	Console.WriteLine (a);                      // Stevie Ray
	Console.WriteLine (b);                      // Vaughn
}
