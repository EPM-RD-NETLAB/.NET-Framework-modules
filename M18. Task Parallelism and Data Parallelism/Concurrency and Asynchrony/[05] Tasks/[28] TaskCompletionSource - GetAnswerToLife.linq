<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var awaiter = GetAnswerToLife().GetAwaiter();
	awaiter.OnCompleted (() => Console.WriteLine (awaiter.GetResult()));
}

Task<int> GetAnswerToLife()
{
	var tcs = new TaskCompletionSource<int>();
	// Create a timer that fires once in 5000 ms:
	var timer = new System.Timers.Timer (5000) { AutoReset = false };
	timer.Elapsed += delegate { timer.Dispose(); tcs.SetResult (42); };
	timer.Start();
	return tcs.Task;
}
