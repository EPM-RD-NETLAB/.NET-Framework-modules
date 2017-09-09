<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DisplayPrimesCount();
}

async void DisplayPrimesCount()
{
	int result = await GetPrimesCountAsync (2, 1000000);
	Console.WriteLine (result);
}

Task<int> GetPrimesCountAsync (int start, int count)
{
	return Task.Run (() =>
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
}