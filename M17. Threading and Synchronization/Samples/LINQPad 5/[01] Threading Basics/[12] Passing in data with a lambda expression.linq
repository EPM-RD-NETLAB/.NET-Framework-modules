<Query Kind="Program" />

static void Main()
{
	Thread t = new Thread ( () => Print ("Hello from t!") );
	t.Start();
}

static void Print (string message) { Console.WriteLine (message); }
