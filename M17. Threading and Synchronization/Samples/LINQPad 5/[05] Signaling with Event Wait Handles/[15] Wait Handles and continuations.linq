<Query Kind="Program" />

static ManualResetEvent _starter = new ManualResetEvent (false);

public static void Main()
{
	RegisteredWaitHandle reg = ThreadPool.RegisterWaitForSingleObject (_starter, Go, "Some Data", -1, true);
	Thread.Sleep (5000);
	Console.WriteLine ("Signaling worker...");
	_starter.Set();
	Console.ReadLine();
	reg.Unregister (_starter);    // Clean up when we’re done.
}

public static void Go (object data, bool timedOut)
{
	Console.WriteLine ("Started - " + data);
	// Perform task...
}
