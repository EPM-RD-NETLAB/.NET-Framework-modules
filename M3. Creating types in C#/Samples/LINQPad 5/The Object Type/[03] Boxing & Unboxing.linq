<Query Kind="Statements" />

// Boxing is the act of casting a value-type instance to a reference-type instance;
// unboxing is the reverse.

int x = 9;
object obj = x;           // Box the int
int y = (int)obj;         // Unbox the int

y.Dump();