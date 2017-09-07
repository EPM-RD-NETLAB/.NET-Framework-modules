<Query Kind="Program">
  
</Query>

// This works for arrays of any rank
void WriteFirstValue (Array a)
{
	Console.Write (a.Rank + "-dimensional; ");
	
	// The indexers array will automatically initialize to all zeros, so
	// passing it into GetValue or SetValue will get/set the zero-based
	// (i.e., first) element in the array.
	
	int[] indexers = new int[a.Rank];
	Console.WriteLine ("First value is " +  a.GetValue (indexers));
}
	
void Main()
{
	int[]  oneD = { 1, 2, 3 };
	int[,] twoD = { {5,6}, {8,9} };
	
	WriteFirstValue (oneD);   // 1-dimensional; first value is 1
	WriteFirstValue (twoD);   // 2-dimensional; first value is 5
}
