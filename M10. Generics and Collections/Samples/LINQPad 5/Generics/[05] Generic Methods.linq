<Query Kind="Program" />

// A generic method declares type parameters within the signature of a method.

static void Swap<T> (ref T a, ref T b)
{
	T temp = a;
	a = b;
	b = temp;
}

static void Main()
{
	int x = 5;
	int y = 10;
	Swap (ref x, ref y);
	
	x.Dump(); y.Dump();
}
