<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var cancelSource = new CancellationTokenSource (5000);	// This tells it to cancel in 5 seconds
	await Foo (cancelSource.Token);
}

async Task Foo (CancellationToken cancellationToken)
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine (i);
		await Task.Delay (1000, cancellationToken);  // Cancellation tokens propagate nicely
	}
}