<Query Kind="Statements" />

// When T? is boxed, the boxed value on the heap contains T, not T?.
// C# also permits the unboxing of nullable types with the as operator:

object o = "string";
int? x = o as int?;
Console.WriteLine (x.HasValue);   // False
