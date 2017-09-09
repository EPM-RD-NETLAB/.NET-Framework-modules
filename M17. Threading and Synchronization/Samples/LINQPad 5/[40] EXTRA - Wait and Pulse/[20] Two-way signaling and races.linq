<Query Kind="Program" />

static readonly object _locker = new object();
static bool _go;

static void Main()
{
	new Thread (SaySomething).Start();
	
	for (int i = 0; i < 5; i++)
		lock (_locker) 
		{
			_go = true;
			Monitor.PulseAll (_locker); }
		}

static void SaySomething()
{
	for (int i = 0; i < 5; i++)
		lock (_locker)
		{
			while (!_go) Monitor.Wait (_locker);
			_go = false;
			Console.WriteLine ("Wassup?");
		}
}