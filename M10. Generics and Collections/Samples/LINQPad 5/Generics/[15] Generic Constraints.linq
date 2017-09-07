<Query Kind="Program" />

/* Constraints can be applied to a type parameter restrict the type arguments.

where T : base-class   // Base class constraint
where T : interface    // Interface constraint
where T : class        // Reference-type constraint
where T : struct       // Value-type constraint (excludes Nullable types)
where T : new()        // Parameterless constructor constraint
where U : T            // Naked type constraint

*/

class     SomeClass {}
interface Interface1 {}

class GenericClass<T> where T : SomeClass, Interface1 {}	// Class & interface constraint

static T Max <T> (T a, T b) where T : IComparable<T>	// Self-referencing interface constraint
{
	return a.CompareTo (b) > 0 ? a : b;
}

static void Main()
{
	int z = Max (5, 10);               // 10
	string last = Max ("ant", "zoo");  // zoo

	z.Dump(); last.Dump();
}