<Query Kind="Program" />

void Main()
{
	ThreadTest.Main();
}

class ThreadTest
{
	bool _done;
		
	public static void Main()
	{
		ThreadTest tt = new ThreadTest();   // Create a common instance
		new Thread (tt.Go).Start();
		tt.Go();
	}
		
	void Go()   // Note that this is an instance method
	{
		if (!_done) { _done = true; Console.WriteLine ("Done"); }
	}
}
