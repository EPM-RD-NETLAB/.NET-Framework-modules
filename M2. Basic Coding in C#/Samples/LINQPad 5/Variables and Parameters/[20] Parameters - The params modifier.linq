<Query Kind="Program" />

// The params parameter modifier on the last parameter of a method accepts any number of parameters
// of a specified type:

static int Sum (params int[] ints)
{
	int sum = 0;
	for (int i = 0; i < ints.Length; i++)
		sum += ints[i];                       // Increase sum by ints[i]
	return sum;
}
	
static void Main()
{
	int total = Sum (1, 2, 3, 4);
	Console.WriteLine (total);              // 10
	
	// The call to Sum above is equivalent to:
	int total2 = Sum (new int[] { 1, 2, 3, 4 } );
}