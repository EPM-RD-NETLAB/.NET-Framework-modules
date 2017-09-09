<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DisplayPrimeCounts();
}

async void DisplayPrimeCounts()
{
	for (int i = 0; i < 10; i++)
		Console.WriteLine (await GetPrimesCountAsync (i*1000000+2, 1000000));
}

Task<int> GetPrimesCountAsync (int start, int count)
{
  return Task.Run (() =>
	ParallelEnumerable.Range (start, count).Count (n => 
	  Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
}