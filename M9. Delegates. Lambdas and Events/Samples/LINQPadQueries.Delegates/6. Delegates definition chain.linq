<Query Kind="Program" />

delegate int Transformer (int x);

static void Main()
{
	Transformer t = Square; 
	t += Cube;
	A a = new A();
	t += a.Do;
	t.GetInvocationList().Dump();
	int x = 2;
	t(x).Dump("Result:");
	x.Dump("x");
}

static int Square (int x) { return x * x; }
static int Cube (int x) { return x * x * x; }

class A
{
	public int Do(int x){ return x; }
}