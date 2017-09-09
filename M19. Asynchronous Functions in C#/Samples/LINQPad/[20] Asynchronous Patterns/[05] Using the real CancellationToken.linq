<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var cancelSource = new CancellationTokenSource();
	Task.Delay (5000).ContinueWith (ant => cancelSource.Cancel());   // Tell it to cancel in two seconds.
	await Foo (cancelSource.Token);
}

async Task Foo (CancellationToken cancellationToken)
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine (i);
		await Task.Delay (1000);
		cancellationToken.ThrowIfCancellationRequested();
	}
}