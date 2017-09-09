<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var cts = new CancellationTokenSource (3000);  // Cancel after 3 seconds
	string result = await SomeAsyncFunc().WithCancellation (cts.Token);
	result.Dump();
}

async Task<string> SomeAsyncFunc()
{
	await Task.Delay (10000);
	return "foo";
}

public static class Extensions
{
	public static Task<TResult> WithCancellation<TResult> (this Task<TResult> task, CancellationToken cancelToken)
	{
		var tcs = new TaskCompletionSource<TResult>();
		var reg = cancelToken.Register (() => tcs.TrySetCanceled ());
		task.ContinueWith (ant => 
		{
			reg.Dispose();		
			if (ant.IsCanceled)
				tcs.TrySetCanceled();
			else if (ant.IsFaulted)
				tcs.TrySetException (ant.Exception.InnerException);
			else
				tcs.TrySetResult (ant.Result);
		});
		return tcs.Task;	
	}
}