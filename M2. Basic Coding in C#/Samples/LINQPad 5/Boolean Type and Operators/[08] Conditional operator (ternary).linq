<Query Kind="Program" />

// The conditional operator (also called the ternary operator) has the form
//    q ? a : b
// where if condition q is true, a is evaluated, else b is evaluated.

static int Max (int a, int b)
{
  return (a > b) ? a : b;
}

static void Main()
{
	Max (2, 3).Dump();
	Max (3, 2).Dump();
}