<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task = Task.Factory.StartNew (() =>
{
	Console.WriteLine ("Task started");
	Thread.Sleep (2000);
	Console.WriteLine ("Foo");
}, TaskCreationOptions.LongRunning);

task.Wait();  // Blocks until task is complete
