<Query Kind="Program" />

void Main()
{
	var cd = new Countdown(5);
	new Thread (() =>
	{
		for (int i = 0; i < 5; i++)
		{
			Thread.Sleep(1000);
			cd.Signal();
			Console.WriteLine ("Signal " + i);
		}
	}).Start();
	Console.WriteLine ("Waiting");
	cd.Wait();
	Console.WriteLine ("Unblocked");
}

public class Countdown
{
	object _locker = new object ();
	int _value;
	
	public Countdown() { }
	public Countdown (int initialCount) { _value = initialCount; }
	
	public void Signal() { AddCount (-1); }
	
	public void AddCount (int amount)
	{
		lock (_locker) 
		{ 
			_value += amount;
			if (_value <= 0) Monitor.PulseAll (_locker);
		}
	}
	
	public void Wait()
	{
		lock (_locker)
			while (_value > 0)
				Monitor.Wait (_locker);
	}
}