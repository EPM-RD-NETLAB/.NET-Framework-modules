<Query Kind="Program" />

// Same examples as before, but with & and | instead of && and ||.
// The results are identical, but without short-circuiting:

static bool UseUmbrella (bool rainy, bool sunny, bool windy)
{
	return !windy & (rainy | sunny);
}

static void Main()
{
	UseUmbrella (true, false, false).Dump();	// True
	UseUmbrella (true, true, true).Dump();		// False
	
	StringBuilder sb = null;

	if (sb != null & sb.Length > 0) 			// Exception is thrown!
		Console.WriteLine ("sb has data");
	else
		Console.WriteLine ("sb is null or empty");
}