<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task parent = Task.Factory.StartNew (() =>
{
	Console.WriteLine ("I am a parent");
	
	Task.Factory.StartNew (() =>        // Detached task
	{
		Console.WriteLine ("I am detached");
	});
	
	Task.Factory.StartNew (() =>        // Child task
	{
		Console.WriteLine ("I am a child");
	}, TaskCreationOptions.AttachedToParent);
});

parent.Wait();
Console.WriteLine ("Parent completed");