<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task1 = Task.Factory.StartNew (() => { throw null; });
Task task2 = task1.ContinueWith (ant => Console.Write (ant.Exception));

task2.Wait();	// throws an AggregateException