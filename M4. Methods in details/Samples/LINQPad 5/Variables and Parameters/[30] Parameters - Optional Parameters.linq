<Query Kind="Program" />

// From C# 4.0, methods, constructors and indexers can declare optional parameters.
// A parameter is optional if it specifies a default value in its declaration:

static void Foo (int x = 23) { Console.WriteLine (x); }

static void Main()
{
	Foo();		// 23
	Foo (23);	// 23  (equivalent to above call)
}