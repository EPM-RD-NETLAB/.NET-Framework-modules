<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Go();
}

void Go()
{
	PrintAnswerToLife();
	Console.WriteLine ("Done");
}

void PrintAnswerToLife()
{
	int answer = GetAnswerToLife();
	Console.WriteLine (answer);
}

int GetAnswerToLife()
{
	Thread.Sleep (5000);
	int answer = 21 * 2;
	return answer;
}
