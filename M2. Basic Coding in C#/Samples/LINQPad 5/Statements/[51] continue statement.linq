<Query Kind="Statements" />

// The continue statement forgoes the remaining statements in a loop and makes an
// early start on the next iteration:

for (int i = 0; i < 10; i++)
{
	if ((i % 2) == 0)		// If i is even,
		continue;			// continue with next iteration

	Console.Write (i + " ");
}