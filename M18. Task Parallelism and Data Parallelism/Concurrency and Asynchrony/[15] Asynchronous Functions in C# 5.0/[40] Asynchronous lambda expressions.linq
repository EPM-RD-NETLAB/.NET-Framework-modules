<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Named asynchronous method:
async Task NamedMethod()
{
	await Task.Delay (1000);
	Console.WriteLine ("Foo");
}

async void Main()
{
	// Unnamed asynchronous method:
	Func<Task> unnamed = async () =>
	{
		await Task.Delay (1000);
		Console.WriteLine ("Foo");
	};

	// We can call the two in the same way:
	await NamedMethod();
	await unnamed();
}