<Query Kind="Statements" />

object obj = 9;

// First, unbox to the correct type (int), then implicitly convert to long:

long x = (int) obj;
x.Dump();

// This also works:

object obj2 = 3.5;              // 3.5 is inferred to be of type double
int y = (int) (double) obj2;    // x is now 3
y.Dump();