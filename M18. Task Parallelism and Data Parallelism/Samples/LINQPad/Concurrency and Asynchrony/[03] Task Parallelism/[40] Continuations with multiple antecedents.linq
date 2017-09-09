<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var task1 = Task.Factory.StartNew (() => Console.Write ("X"));
var task2 = Task.Factory.StartNew (() => Console.Write ("Y"));

var continuation = Task.Factory.ContinueWhenAll (
	new[] { task1, task2 }, tasks => Console.WriteLine ("Done"));
