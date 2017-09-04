<Query Kind="Statements" />

if (2 + 2 == 5)
	Console.WriteLine ("Does not compute");
else
	Console.WriteLine ("false");        // False

// If/else statements can be nested:
	
if (2 + 2 == 5)
	Console.WriteLine ("Does not compute");
else
	if (2 + 2 == 4)
		Console.WriteLine ("Computes");    // Computes
		
// The above is commonly formatted as follows:

if (2 + 2 == 5)
	Console.WriteLine ("Does not compute");
else if (2 + 2 == 4)
	Console.WriteLine ("Computes");    // Computes