<Query Kind="Statements" />

// C# supports goto - in case you really want it!

int i = 1;

startLoop:
if (i <= 5)
{
	Console.Write (i + " ");
	i++;
	goto startLoop;
}