<Query Kind="Program" />

// In the following example, the variables x and y represent the same instance:

static int x;

static void Main() { Foo (out x); }

static void Foo (out int y)
{
	Console.WriteLine (x);                // x is 0
	y = 1;                                // Mutate y
	Console.WriteLine (x);                // x is 1
}
