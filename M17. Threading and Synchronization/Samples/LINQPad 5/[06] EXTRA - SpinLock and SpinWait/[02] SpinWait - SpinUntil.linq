<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

bool _proceed;

void Main()
{
	var task = Task.Factory.StartNew (Test);
	Thread.Sleep(1000);
	_proceed = true;
	task.Wait();
}

void Test()
{
	SpinWait.SpinUntil (() => { Thread.MemoryBarrier(); return _proceed; });
	"Done!".Dump();
}

