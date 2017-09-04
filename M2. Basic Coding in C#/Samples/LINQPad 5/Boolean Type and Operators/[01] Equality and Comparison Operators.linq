<Query Kind="Statements" />

// == and != test for equality and inequality of any type, but always return a bool value
// (unless overloaded otherwise). Value types typically have a very simple notion of equality:

int x = 1;
int y = 2;
int z = 1;

Console.WriteLine (x == y);		// False
Console.WriteLine (x != y);		// True
Console.WriteLine (x == z);		// True

Console.WriteLine (x < y);		// True
Console.WriteLine (x >= z);		// True