<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task<int> primeNumberTask = Task.Run (() =>
	Enumerable.Range (2, 3000000).Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));

Console.WriteLine ("Task running...");
Console.WriteLine ("The answer is " + primeNumberTask.Result);