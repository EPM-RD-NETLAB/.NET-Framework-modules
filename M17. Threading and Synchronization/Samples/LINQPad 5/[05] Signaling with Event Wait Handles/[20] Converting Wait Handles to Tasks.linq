<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var myWaitHandle = new AutoResetEvent (true);
	await myWaitHandle.ToTask();
	"Done".Dump();
}

public static class Extensions
{
	public static Task<bool> ToTask (this WaitHandle waitHandle, int timeout = -1)
	{
		var tcs = new TaskCompletionSource<bool>();
		RegisteredWaitHandle token = null;
		var tokenReady = new ManualResetEventSlim();
		
		token = ThreadPool.RegisterWaitForSingleObject (
			waitHandle, 
			(state, timedOut) => 
			{
				tokenReady.Wait();
				tokenReady.Dispose();
				token.Unregister (waitHandle);
				tcs.SetResult (!timedOut); 
			},
			null,
			timeout, 
			true);

		tokenReady.Set();
		return tcs.Task;
	}
}