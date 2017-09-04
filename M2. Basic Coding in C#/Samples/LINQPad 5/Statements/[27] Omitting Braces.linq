<Query Kind="Program" />

// Braces don't necessarily help readability. The following is clear without braces:

static void TellMeWhatICanDo (int age)
{
	if (age >= 35)
		Console.WriteLine ("You can be president!");
	else if (age >= 21)
		Console.WriteLine ("You can drink!");
	else if (age >= 18)
		Console.WriteLine ("You can vote!");
	else
		Console.WriteLine ("You can wait!");
}

static void Main()
{
	TellMeWhatICanDo (55);
	TellMeWhatICanDo (30);
	TellMeWhatICanDo (20);
	TellMeWhatICanDo (8);	
}