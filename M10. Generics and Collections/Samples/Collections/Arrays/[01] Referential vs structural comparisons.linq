<Query Kind="Statements">
  
</Query>

object[] a1 = { "string", 123, true };
object[] a2 = { "string", 123, true };

Console.WriteLine (a1 == a2);                          // False
Console.WriteLine (a1.Equals (a2));                    // False

IStructuralEquatable se1 = a1;

Console.WriteLine (se1.Equals (a2, StructuralComparisons.StructuralEqualityComparer));   // True
