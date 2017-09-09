<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// This will throw an exception immediately.

async void Main()
{
	Task<int> task1 = Task.Run (() => { throw null; return 42; } );
	Task<int> task2 = Task.Delay (5000).ContinueWith (ant => 53);
	
	int[] results = await WhenAllOrError (task1, task2);
}

async Task<TResult[]> WhenAllOrError<TResult> (params Task<TResult>[] tasks)
{
	var killJoy = new TaskCompletionSource<TResult[]>();
	
	foreach (var task in tasks)
		task.ContinueWith (ant =>
		{
			if (ant.IsCanceled) 
				killJoy.TrySetCanceled();
			else if (ant.IsFaulted)
				killJoy.TrySetException (ant.Exception.InnerException);
		});
		
	return await await Task.WhenAny (killJoy.Task, Task.WhenAll (tasks));		
}