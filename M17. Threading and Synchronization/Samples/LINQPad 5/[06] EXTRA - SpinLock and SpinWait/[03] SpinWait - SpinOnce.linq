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
	var spinWait = new SpinWait();
	while (!_proceed) { Thread.MemoryBarrier(); spinWait.SpinOnce(); }
	"Done!".Dump();
}

