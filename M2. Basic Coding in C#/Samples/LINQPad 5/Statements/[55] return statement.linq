<Query Kind="Program" />

// A return statement can appear anywhere in a method.

static void Main()
{
	AsPercentage (0.345m).Dump();	
}

static decimal AsPercentage (decimal d)
{
	decimal p = d * 100m;
	return p;             // Return to the calling method with value
}