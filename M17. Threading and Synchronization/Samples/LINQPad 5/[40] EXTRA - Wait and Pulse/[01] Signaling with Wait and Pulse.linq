<Query Kind="Program" />

// See http://www.albahari.com/threading/part4.aspx ("Signaling with Wait and Pulse") for the accompanying text.

static readonly object _locker = new object();
static bool _go;

static void Main()
{                                // The new thread will block because _go==false.
	new Thread (Work).Start();   
	Console.WriteLine ("Press Enter to signal");
	Console.ReadLine();          // Wait for user to hit Enter

	lock (_locker)                 // Let's now wake up the thread by
	{                              // setting _go=true and pulsing.
		_go = true;
		Monitor.Pulse (_locker);
	}
}

static void Work()
{
	lock (_locker)
	while (!_go)
	Monitor.Wait (_locker);    // Lock is released while we’re waiting
	
	Console.WriteLine ("Woken!!!");
}