<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var thread = new Thread (Foo);
	thread.Start();
	Thread.Sleep(100);
	var trace = GetTraceOnThread (thread);
	if (trace == null) 
		"Bad luck, deadlocked!".Dump();
	else
		trace.GetFrames().Dump();
}

StackTrace GetTraceOnThread (Thread targetThread)
{
	StackTrace stackTrace = null;
	var ready = new ManualResetEventSlim();
	
	new Thread (() =>
	{
		// Backstop to release thread in case of deadlock:
		ready.Set();
		Thread.Sleep (200);
		try { targetThread.Resume(); } catch { }
	}).Start();
	
	ready.Wait();
	targetThread.Suspend();
	try { stackTrace = new StackTrace (targetThread, true); }
	catch { /* Deadlock */ }
	finally
	{
		try { targetThread.Resume(); } 
		catch { stackTrace = null;  /* Deadlock */  }
	}	
	return stackTrace;
}

void Foo()
{
	Thread.Sleep(5000);
}