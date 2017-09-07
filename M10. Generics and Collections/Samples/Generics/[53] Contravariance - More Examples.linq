<Query Kind="Program" />

/* The following interface is defined as part of the .NET Framework:

public interface IComparer<in T>
{
  // Returns a value indicating the relative ordering of a and b
  int Compare (T a, T b);
}

*/

static void Main() 
{
	var objectComparer = Comparer<object>.Default;
	IComparer<string> stringComparer = objectComparer;
	int result = stringComparer.Compare ("Brett", "Jemaine");
	result.Dump();
}
