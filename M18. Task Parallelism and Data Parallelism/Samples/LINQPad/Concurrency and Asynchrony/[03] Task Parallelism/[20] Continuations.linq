<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task1 = Task.Factory.StartNew (() => Console.Write ("antecedant.."));
Task task2 = task1.ContinueWith (ant => Console.Write ("..continuation"));

