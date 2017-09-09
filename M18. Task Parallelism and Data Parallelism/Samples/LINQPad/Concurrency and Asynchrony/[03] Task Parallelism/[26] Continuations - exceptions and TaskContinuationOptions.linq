<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task1 = Task.Factory.StartNew (() => { throw null; });

Task error = task1.ContinueWith (ant => Console.Write (ant.Exception),
								 TaskContinuationOptions.OnlyOnFaulted);

Task ok = task1.ContinueWith (ant => Console.Write ("Success!"),
							  TaskContinuationOptions.NotOnFaulted);

error.Wait();