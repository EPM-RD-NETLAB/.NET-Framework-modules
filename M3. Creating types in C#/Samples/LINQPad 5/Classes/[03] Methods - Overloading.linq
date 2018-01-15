<Query Kind="Program" />

// We can overload Foo as follows:

void Foo (int x)			{ "int".Dump(); }
void Foo (double x)			{ "double".Dump(); }
void Foo (int x, float y)	{ "int, float".Dump(); }
void Foo (float x, int y)	{ "float, int".Dump(); }

void Main()
{
	Foo (123);			// int
	Foo (123.0);		// double
	Foo (123, 123F);	// int, float
	Foo (123F, 123);	// float, int
}