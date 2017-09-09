<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task.Factory.StartNew<int> (() => 8)
	.ContinueWith (ant => ant.Result * 2)
	.ContinueWith (ant => Math.Sqrt (ant.Result))
	.ContinueWith (ant => Console.WriteLine (ant.Result));   // 4
	
