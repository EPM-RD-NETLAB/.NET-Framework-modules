<Query Kind="Statements" />

// An else clause always applies to the immediately preceding if statement in the statement block:
if (true)
	if (false)
		Console.WriteLine();
	else
		Console.WriteLine ("executes");
	
// This is semantically identical to:
if (true)
{
	if (false)
		Console.WriteLine();
	else
		Console.WriteLine ("executes");
}

// We can change the execution flow by moving the braces:
if (true)
{
	if (false)
		Console.WriteLine();
}
else
	Console.WriteLine ("does not execute");