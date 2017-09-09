<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

int x = 2;

void Main()
{
	// We can perform three multiplications on the same variable using 3 concurrent threads
	// safely without locks by using SpinWait with Interlocked.CompareExchange.
	
	var task1 = Task.Factory.StartNew (() => MultiplyXBy (3));
	var task2 = Task.Factory.StartNew (() => MultiplyXBy (4));
	var task3 = Task.Factory.StartNew (() => MultiplyXBy (5));
	
	Task.WaitAll (task1, task2, task3);
	x.Dump();
}

void MultiplyXBy (int factor)
{
	var spinWait = new SpinWait();
	while (true)
	{
		int snapshot1 = x;
		Thread.MemoryBarrier();
		int calc = snapshot1 * factor;
		int snapshot2 = Interlocked.CompareExchange (ref x, calc, snapshot1);
		if (snapshot1 == snapshot2) return;   // No one preempted us.
		spinWait.SpinOnce();
	}
}