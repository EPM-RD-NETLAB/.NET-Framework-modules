<Query Kind="Statements" />

// With a do-while loop, the check is performed at the end, so the body always executes at least once:

int i = 0;
do
{
	Console.WriteLine (i);
	i++;
}
while (i < 3);