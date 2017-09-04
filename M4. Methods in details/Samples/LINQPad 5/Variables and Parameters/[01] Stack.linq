<Query Kind="Program" />

// The stack is a block of memory for storing local variables and parameters.

static void Main()
{
	Factorial(5).Dump();
}

// For each call to Factorial, x gets pushed onto the stack:

static int Factorial (int x)
{
	if (x == 0) return 1;
	return x * Factorial (x-1);
}