<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var t = Task.Factory.StartNew (() => Thread.Sleep (1000));

var c1 = t.ContinueWith (ant => Console.Write ("X"));
var c2 = t.ContinueWith (ant => Console.Write ("Y"));

Task.WaitAll (c1, c2);

