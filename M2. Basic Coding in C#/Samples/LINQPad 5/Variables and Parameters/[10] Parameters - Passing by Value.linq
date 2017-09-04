<Query Kind="Program" />

// By default, arguments in C# are passed by value.
// This means a copy of the value is created when passed to the method:

static void Foo (int p)
{
	p = p + 1;							// Increment p by 1
	Console.WriteLine ("p is " + p);	// Write p to screen
}

static void Main()
{
	int x = 8;
	Foo (x);                  			// Make a copy of x
	Console.WriteLine ("x is " + x);	// x will still be 8
}
