<Query Kind="Program" />

static readonly object _locker = new object();
static bool _ready, _go;

static void Main()
{
	new Thread (SaySomething).Start();
	
	for (int i = 0; i < 5; i++)
		lock (_locker)
		{
			while (!_ready) Monitor.Wait (_locker);
			_ready = false;
			_go = true;
			Monitor.PulseAll (_locker);
		}
}

static void SaySomething()
{
	for (int i = 0; i < 5; i++)
		lock (_locker)
		{
			_ready = true;
			Monitor.PulseAll (_locker);           // Remember that calling
			while (!_go) Monitor.Wait (_locker);  // Monitor.Wait releases
			_go = false;                          // and reacquires the lock.
			Console.WriteLine ("Wassup?");
		}
}