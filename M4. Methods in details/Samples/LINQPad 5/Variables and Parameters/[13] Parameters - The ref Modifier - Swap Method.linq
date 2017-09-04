<Query Kind="Program" />

// The ref modifier is essential in implementing a swap method:

static void Swap (ref string a, ref string b)
{
	string temp = a;
	a = b;
	b = temp;
}
	
static void Main()
{
	string x = "Penn";
	string y = "Teller";
	Swap (ref x, ref y);
	Console.WriteLine (x);   // Teller
	Console.WriteLine (y);   // Penn
}
