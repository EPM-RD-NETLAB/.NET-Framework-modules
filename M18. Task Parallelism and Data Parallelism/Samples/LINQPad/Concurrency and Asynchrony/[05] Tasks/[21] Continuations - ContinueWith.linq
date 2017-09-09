<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// (See Chapter 23 for more on using ContinueWith.)

Task<int> primeNumberTask = Task.Run (() =>
	Enumerable.Range (2, 3000000).Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));

primeNumberTask.ContinueWith (antecedent => 
{
	int result = antecedent.Result;
	Console.WriteLine (result);          // Writes 123
});
