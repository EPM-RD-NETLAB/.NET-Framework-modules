<Query Kind="Statements" />

// The scope of a local or constant variable extends throughout the current block:

int x;
{
	int y;
	int x;            // Error - x already defined
}

{
	int y;            // OK - y not in scope
}

Console.Write (y);  // Error - y is out of scope