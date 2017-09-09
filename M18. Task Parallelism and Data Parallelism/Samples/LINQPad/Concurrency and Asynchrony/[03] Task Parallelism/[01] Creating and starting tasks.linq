<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Note: see Chapter 14 for a basic introduction to tasks.

var task = Task.Run (() => Console.WriteLine ("Hello from a task!"));
task.Wait();	// Wait for task to finish