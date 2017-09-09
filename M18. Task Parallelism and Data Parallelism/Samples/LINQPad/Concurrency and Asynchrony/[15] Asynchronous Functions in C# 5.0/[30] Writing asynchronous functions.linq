<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Go();
}

async Task Go()
{
	await PrintAnswerToLife();
	Console.WriteLine ("Done");
}

async Task PrintAnswerToLife()   // We can return Task instead of void
{
	await Task.Delay (5000);
	int answer = 21 * 2;
	Console.WriteLine (answer);  
}
