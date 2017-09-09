<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Task<string> task = SomeAsyncFunc();
	Task winner = await (Task.WhenAny (task, Task.Delay(5000)));
	if (winner != task) throw new TimeoutException();
	string result = await task;   // Unwrap result/re-throw
}

async Task<string> SomeAsyncFunc()
{
	await Task.Delay (10000);
	return "foo";
}