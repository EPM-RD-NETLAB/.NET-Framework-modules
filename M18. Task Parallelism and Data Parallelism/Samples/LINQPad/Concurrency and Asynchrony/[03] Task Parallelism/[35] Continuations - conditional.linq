<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task t1 = Task.Factory.StartNew (() => Console.WriteLine ("nothing awry here"));

Task fault = t1.ContinueWith (ant => Console.WriteLine ("fault"),
							  TaskContinuationOptions.OnlyOnFaulted);

Task t3 = fault.ContinueWith (ant => Console.WriteLine ("t3"));		// This executes

