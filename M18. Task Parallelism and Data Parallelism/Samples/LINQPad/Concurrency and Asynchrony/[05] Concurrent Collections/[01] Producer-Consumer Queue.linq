<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	using (var q = new PCQueue(1))
	{
		q.EnqueueTask (() => "Foo".Dump());
		q.EnqueueTask (() => "Far".Dump());
	}	
}

public class PCQueue : IDisposable
{
	BlockingCollection<Action> _taskQ = new BlockingCollection<Action>();
	
	public PCQueue (int workerCount)
	{
		// Create and start a separate Task for each consumer:
		for (int i = 0; i < workerCount; i++)
			Task.Factory.StartNew (Consume);
	}
	
	public void Dispose() { _taskQ.CompleteAdding(); }
	
	public void EnqueueTask (Action action) { _taskQ.Add (action); }
	
	void Consume()
	{
		// This sequence that we’re enumerating will block when no elements
		// are available and will end when CompleteAdding is called.
	
		foreach (Action action in _taskQ.GetConsumingEnumerable())
			action();     // Perform task.
	}	
}