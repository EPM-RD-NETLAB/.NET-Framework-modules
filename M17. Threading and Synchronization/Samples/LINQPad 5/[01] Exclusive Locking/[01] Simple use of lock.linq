<Query Kind="Program" />

static readonly object _locker = new object();
static int _val1, _val2;

static void Main()
{
	new Thread (Go).Start();
	new Thread (Go).Start();
	new Thread (Go).Start();
}

static void Go()
{
	lock (_locker)	// Threadsafe: will never get DivideByZeroException
	{
		if (_val2 != 0) Console.WriteLine (_val1 / _val2);
		_val2 = 0;
	}
}
