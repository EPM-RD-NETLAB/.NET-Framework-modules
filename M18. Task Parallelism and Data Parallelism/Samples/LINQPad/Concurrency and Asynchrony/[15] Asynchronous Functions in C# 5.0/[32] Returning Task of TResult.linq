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

async Task PrintAnswerToLife()
{
	int answer = await GetAnswerToLife();
	Console.WriteLine (answer);
}

async Task<int> GetAnswerToLife()
{
	await Task.Delay (5000);
	int answer = 21 * 2;
	return answer;
}
