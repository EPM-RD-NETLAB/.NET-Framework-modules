<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	using (var pcQ = new PCQueue(1))
	{
		Task task1 = pcQ.Enqueue (() => Console.WriteLine ("Too"));
		Task task2 = pcQ.Enqueue (() => Console.WriteLine ("Easy!"));
		
		task1.ContinueWith (_ => "Task 1 complete".Dump());
		task2.ContinueWith (_ => "Task 2 complete".Dump());
	}	
}

public class PCQueue : IDisposable
{
	BlockingCollection<Task> _taskQ = new BlockingCollection<Task>();
	
	public PCQueue (int workerCount)
	{
		// Create and start a separate Task for each consumer:
		for (int i = 0; i < workerCount; i++)
		Task.Factory.StartNew (Consume);
	}
	
	public Task Enqueue (Action action, CancellationToken cancelToken = default (CancellationToken))
	{
		var task = new Task (action, cancelToken);
		_taskQ.Add (task);
		return task;
	}
	
	public Task<TResult> Enqueue<TResult> (Func<TResult> func, 
		CancellationToken cancelToken = default (CancellationToken))
	{
		var task = new Task<TResult> (func, cancelToken);
		_taskQ.Add (task);
		return task;
	}
	
	void Consume()
	{
		foreach (var task in _taskQ.GetConsumingEnumerable())
		try 
		{
			if (!task.IsCanceled) task.RunSynchronously();
		} 
		catch (InvalidOperationException) { }  // Race condition
	}
	
	public void Dispose() { _taskQ.CompleteAdding(); }
}
