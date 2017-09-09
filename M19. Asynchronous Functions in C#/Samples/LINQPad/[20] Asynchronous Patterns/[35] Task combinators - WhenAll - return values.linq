<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Task<int> task1 = Task.Run (() => 1);
	Task<int> task2 = Task.Run (() => 2);
	int[] results = await Task.WhenAll (task1, task2);   // { 1, 2 }	
	results.Dump();
}
