<Query Kind="Statements" />

Action[] actions = new Action[3];
for (int i = 0; i < 3; i++)
{
	int j = i;
	actions[i] = delegate { Console.WriteLine(j);};
}

foreach(var action in actions) 
	action();