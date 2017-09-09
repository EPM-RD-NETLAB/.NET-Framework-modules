<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Task task1 = Task.Run (() => { throw null; } );
	Task task2 = Task.Run (() => { throw null; } );
	Task all = Task.WhenAll (task1, task2);
	try { await all; }
	catch
	{
		Console.WriteLine (all.Exception.InnerExceptions.Count);   // 2 
	}    
}
