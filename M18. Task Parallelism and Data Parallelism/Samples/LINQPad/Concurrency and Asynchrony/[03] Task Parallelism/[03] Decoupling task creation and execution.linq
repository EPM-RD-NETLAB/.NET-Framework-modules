<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// You can create "cold" (unstarted) tasks with Task's constructor:
var task = new Task (() => Console.Write ("Hello"));

"We can do something else here...".Dump();

task.Start();
