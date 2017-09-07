<Query Kind="Program" />

// A delegate type declaration is like an abstract method declaration,
// prefixed with the delegate keyword:

delegate int Transformer (int x);

static void Main()
{
	//A a = new A();
	Transformer fr = Square;//<=>Transformer fr = new Transformer(Square)
	fr.Dump();
	if (fr != null) fr(1);
	fr?.Invoke(2);

	fr += Cube;
	fr += new A().Power;
	fr += Cube;
	fr += Square;
	fr -= Cube;
	fr -= Square;
	fr(2).Dump();
	Delegate[] arr = fr.GetInvocationList();
	for (int i = 0; i < arr.Length; i++)
	{
		((Transformer)arr[i])(2).Dump();
	}

	//fr.Invoke(3).Dump();//<=>fr(3).Dump();
	//Transformer fr1 = delegate (int x) { return x * x * x; };
	Transformer fr1 = x => x * x * x;
	fr1 += delegate (int x) { return x * x * x * x; };
	fr1 += x => x * x * x * x;
	fr1 -= delegate (int x) { return x * x * x * x; };
	fr1.Invoke(3).Dump();
	//Transformer fr2 = new Transformer(new A().Power);
	//fr2.Invoke(3).Dump();
//	Do(new Transformer(Square));
//	Do(new Transformer(Cube));
//	Do(new A().Power);
	

	//	Transformer t = Square;
////	Transformer t1 = Cube;
////	t.GetHashCode().Dump();
////	t1.GetHashCode().Dump();
////	t += Cube;
////	t += Square;
//	t.Dump();
////	t1 += Cube;
////	t.GetHashCode().Dump();
////	t1.GetHashCode().Dump();
//	int result = t(3);
//	Console.WriteLine(result);
//	result = t(4);
//	Console.WriteLine(result);
	//Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
	//	Assembly.GetExecutingAssembly().Location);
}

static void Do(Transformer del)
{
	//TODO
	int x = 2;
	int result = del(2);
	result.Dump();
	//TODO
}

static int Square(int x) { return x * x; }
static int Cube(int x) { return x * x * x; }
static int Foo(int x, int y) { return x * x * x; }

class A
{
	public int Power(int x) { return x * x * x * x; }
}