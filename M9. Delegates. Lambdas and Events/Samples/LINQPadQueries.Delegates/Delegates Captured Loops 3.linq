<Query Kind="Statements" />

Action[] actions = new Action[3];

int k = 0;
foreach (var c in "abc")
{
	actions[k++] = delegate{ Console.Write(c); };
}

foreach (var action in actions)
{
	action();
}