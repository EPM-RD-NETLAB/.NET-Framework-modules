<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Task<int> winningTask = await Task.WhenAny (Delay1(), Delay2(), Delay3());
	Console.WriteLine ("Done");
	Console.WriteLine (await winningTask);   // 1
}

async Task<int> Delay1() { await Task.Delay (1000); return 1; }
async Task<int> Delay2() { await Task.Delay (2000); return 2; }
async Task<int> Delay3() { await Task.Delay (3000); return 3; }

