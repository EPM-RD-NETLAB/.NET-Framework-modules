<Query Kind="Program" />

// To pass by reference, C# provides the ref parameter modifier.
// In the following example, p and x refer to the same memory locations:

static void Foo (ref int p)
{
	p = p + 1;               // Increment p by 1
	Console.WriteLine (p);   // Write p to screen
}

static void Main()
{
	int x = 8;
	Foo (ref  x);            // Ask Foo to deal directly with x
	Console.WriteLine (x);   // x is now 9
}
