<Query Kind="Program" />

// Foo1 and Foo2 are equivalent:

int Foo1 (int x) { return x * 2; }
int Foo2 (int x) => x * 2;

void Main()
{
	Foo1 (10).Dump();
	Foo2 (10).Dump();
}