<Query Kind="Statements" />

for (int i = 0; i < 10; i++)
{
	int temp = i;
	new Thread (() => Console.Write (temp)).Start();
}
