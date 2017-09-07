<Query Kind="Program" />

delegate int Transformer (ref int x);

static void Main()
{
	Transformer t = Square; 
	t += Cube;
	int x = 2;
	t(ref x).Dump("Result:");
	x.Dump("x");	
}

static int Square (ref int x) { return x = x * x; }
static int Cube (ref int x) { return x * x * x; }