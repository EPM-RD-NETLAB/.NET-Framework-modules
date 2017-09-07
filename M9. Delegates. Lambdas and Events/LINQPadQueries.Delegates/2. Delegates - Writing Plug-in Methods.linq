<Query Kind="Program" />

// A delegate variable is assigned a method dynamically. 
//This is useful for writing plug-in methods:

delegate int Transformer(int x);

class Util
{
	public static void Transform (int[] values, Transformer t)
  {
	for (int i = 0; i < values.Length; i++)
	  values[i] = t (values[i]);
  }
}

static void Main()
{
	int[] values = { 1, 2, 3 };
	Util.Transform (values, Square);      // Dynamically hook in Square
	values.Dump();
	
	values = new int[] { 1, 2, 3 };
	new Transformer(new DemoInstanceDelegate().Cube).Dump();
	Util.Transform (values, new DemoInstanceDelegate().Cube);        // Dynamically hook in Cube
	values.Dump();
}

static int Square (int x) { return x * x; }

class DemoInstanceDelegate
{
	public int Cube(int x) { return x * x * x; }
}