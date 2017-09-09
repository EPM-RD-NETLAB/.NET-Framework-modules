<Query Kind="Statements" />

for (int i = 0; i < 10; i++)
	new Thread (() => Console.Write (i)).Start();
