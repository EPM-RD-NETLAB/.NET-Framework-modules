<Query Kind="Statements" />

int Age = 23;

// The following:
{
	var dude = new { Name = "Bob", Age, Age.ToString().Length };
	dude.Dump();
}
// is shorthand for:
{
	var dude = new { Name = "Bob", Age = Age, Length = Age.ToString().Length };
	dude.Dump();
}
