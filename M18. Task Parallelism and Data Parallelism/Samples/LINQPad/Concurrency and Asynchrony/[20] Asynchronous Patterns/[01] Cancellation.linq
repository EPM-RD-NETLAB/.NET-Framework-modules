<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var token = new CancellationToken();
	Task.Delay (5000).ContinueWith (ant => token.Cancel());   // Tell it to cancel in two seconds.
	await Foo (token);
}

// This is a simplified version of the CancellationToken type in System.Threading:
class CancellationToken
{
	public bool IsCancellationRequested { get; private set; }
	public void Cancel() { IsCancellationRequested = true; }
	public void ThrowIfCancellationRequested()
	{
		if (IsCancellationRequested) throw new OperationCanceledException();
	}
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