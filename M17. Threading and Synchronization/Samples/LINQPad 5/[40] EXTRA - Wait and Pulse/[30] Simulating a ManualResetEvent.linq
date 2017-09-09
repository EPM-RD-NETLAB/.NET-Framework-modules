<Query Kind="Program" />

void Main()
{
	new Thread (() => { Thread.Sleep (2000); Set(); }).Start();
	Console.WriteLine ("Waiting...");
	WaitOne();
	Console.WriteLine ("Signaled");
}

readonly object _locker = new object();
bool _signal;
 
void WaitOne()
{
	lock (_locker)
	{
		while (!_signal) Monitor.Wait (_locker);
	}
}
 
void Set()
{
	lock (_locker) { _signal = true; Monitor.PulseAll (_locker); }
}
 
void Reset() { lock (_locker) _signal = false; }