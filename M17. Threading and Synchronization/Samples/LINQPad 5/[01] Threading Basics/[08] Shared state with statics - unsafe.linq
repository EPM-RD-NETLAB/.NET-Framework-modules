<Query Kind="Program" />

void Main()
{
	ThreadTest.Main();
}

class ThreadTest 
{
	static bool _done;    // Static fields are shared between all threads
						// in the same application domain.
	public static void Main()
	{
		new Thread (Go).Start();
		Go();
	}
	
	static void Go()
	{
		if (!_done) { _done = true; Console.WriteLine ("Done"); }
	}
}
