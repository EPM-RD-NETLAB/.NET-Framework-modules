<Query Kind="Program" />

// Non-deterministic!

static readonly object _locker = new object();

static void Main()
{
	new Thread (Work).Start();
	lock (_locker) Monitor.Pulse (_locker);
}
 
static void Work()
{
	lock (_locker) Monitor.Wait (_locker);
	Console.WriteLine ("Woken!!!");
}