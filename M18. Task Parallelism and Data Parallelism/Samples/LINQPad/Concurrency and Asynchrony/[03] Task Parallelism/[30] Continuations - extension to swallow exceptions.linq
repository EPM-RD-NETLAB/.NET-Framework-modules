<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task.Factory.StartNew (() => { throw null; }).IgnoreExceptions();
}

static class Extensions
{
	public static void IgnoreExceptions (this Task task)
	{
		// This could be improved by adding code to log the exception
		task.ContinueWith (t => { var ignore = t.Exception; },
			TaskContinuationOptions.OnlyOnFaulted);
	} 
}