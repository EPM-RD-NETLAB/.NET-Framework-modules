<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Start a Task that throws a NullReferenceException:
Task task = Task.Run (() => { throw null; });
try 
{
	task.Wait();
}
catch (AggregateException aex)
{
	if (aex.InnerException is NullReferenceException)
		Console.WriteLine ("Null!");
	else
		throw;
}
