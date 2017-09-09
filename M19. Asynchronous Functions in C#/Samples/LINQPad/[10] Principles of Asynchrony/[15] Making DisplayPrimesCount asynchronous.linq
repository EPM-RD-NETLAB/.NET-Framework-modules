<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DisplayPrimeCountsAsync();
}

Task DisplayPrimeCountsAsync()
{
	var machine = new PrimesStateMachine();
	machine.DisplayPrimeCountsFrom (0);
	return machine.Task;
}

class PrimesStateMachine		// Even more awkward!!
{
	TaskCompletionSource<object> _tcs = new TaskCompletionSource<object>();
	public Task Task { get { return _tcs.Task; } }
	
	public void DisplayPrimeCountsFrom (int i)
	{
		var awaiter = GetPrimesCountAsync (i*1000000+2, 1000000).GetAwaiter();
		awaiter.OnCompleted (() => 
		{
			Console.WriteLine (awaiter.GetResult());
			if (i++ < 10) DisplayPrimeCountsFrom (i);
			else { Console.WriteLine ("Done"); _tcs.SetResult (null); }
		});
	}
	
	Task<int> GetPrimesCountAsync (int start, int count)
	{
		return Task.Run (() => 
			ParallelEnumerable.Range (start, count).Count (n => 
				Enumerable.Range (2, (int) Math.Sqrt(n)-1).All (i => n % i > 0)));
	}
}
