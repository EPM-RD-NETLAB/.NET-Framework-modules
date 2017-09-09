<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Action<int> progress = i => Console.WriteLine (i + " %");
	await Foo (progress);
}

Task Foo (Action<int> onProgressPercentChanged)
{
	return Task.Run (() =>
	{
		for (int i = 0; i < 1000; i++)
		{
			if (i % 10 == 0) onProgressPercentChanged (i / 10);
			// Do something compute-bound...
		}
	});
}
