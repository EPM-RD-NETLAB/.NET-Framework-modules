<Query Kind="Program" />

void Main()
{
	ThreadSafe.Main();
}

class ThreadSafe 
{
	static bool _done;
	static readonly object _locker = new object();
	
	public static void Main()
	{
		new Thread (Go).Start();
		Go();
	}
	
	static void Go()
	{
		lock (_locker)
		{
			if (!_done) { Console.WriteLine ("Done"); _done = true; }
		}
	}
}
