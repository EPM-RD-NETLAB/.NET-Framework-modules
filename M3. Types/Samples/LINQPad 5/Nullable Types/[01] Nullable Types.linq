<Query Kind="Statements" />

// To represent null in a value type, you must use a special construct called a nullable type:
{
	int? i = null;                     // Nullable Type
	Console.WriteLine (i == null);     // True
}
// Equivalent to:
{
	Nullable<int> i = new Nullable<int>();
	Console.WriteLine (! i.HasValue);           // True
}