<Query Kind="Program" />

static object _locker = new object();
 
static CountdownEvent _countdown = new CountdownEvent(2);

public static void Main()
{
	// Get each thread to sleep a random amount of time.
	Random r = new Random();
	new Thread (Mate).Start (r.Next (10000));
	Thread.Sleep (r.Next (10000));
	
	_countdown.Signal();
	_countdown.Wait();
	
	Console.Write ("Mate! ");
}

static void Mate (object delay)
{
	Thread.Sleep ((int) delay);
	
	_countdown.Signal();
	_countdown.Wait();
	
	Console.Write ("Mate! ");
}