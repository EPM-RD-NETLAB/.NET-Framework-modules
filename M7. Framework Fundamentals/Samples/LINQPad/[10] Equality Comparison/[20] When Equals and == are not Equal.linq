<Query Kind="Statements" />

// With value types, it's quite rare:
double x = double.NaN;
Console.WriteLine (x == x);            // False
Console.WriteLine (x.Equals (x));      // True

// With reference types, it's more common:
var sb1 = new StringBuilder ("foo");
var sb2 = new StringBuilder ("foo");
Console.WriteLine (sb1 == sb2);          // False (referential equality)
Console.WriteLine (sb1.Equals (sb2));    // True  (value equality)
