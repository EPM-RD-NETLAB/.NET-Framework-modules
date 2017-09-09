<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	string result = await SomeAsyncFunc().WithTimeout (TimeSpan.FromSeconds (2));
	result.Dump();
}

async Task<string> SomeAsyncFunc()
{
	await Task.Delay (10000);
	return "foo";
}

public static class Extensions
{
	public async static Task<TResult> WithTimeout<TResult> (this Task<TResult> task, TimeSpan timeout)
	{
		Task winner = await (Task.WhenAny (task, Task.Delay (timeout)));
		if (winner != task) throw new TimeoutException();
		return await task;   // Unwrap result/re-throw
	}
}