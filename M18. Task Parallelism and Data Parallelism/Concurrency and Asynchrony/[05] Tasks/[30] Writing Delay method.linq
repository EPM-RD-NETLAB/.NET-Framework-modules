<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Delay (5000).GetAwaiter().OnCompleted (() => Console.WriteLine (42));
}

Task Delay (int milliseconds)
{
	var tcs = new TaskCompletionSource<object>();
	var timer = new System.Timers.Timer (milliseconds) { AutoReset = false };
	timer.Elapsed += delegate { timer.Dispose(); tcs.SetResult (null); };
	timer.Start();
	return tcs.Task;
}
