<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

var c1 = new Complex (2, 3.5);
var c2 = new Complex (3, 0);

c1.Dump ("c1"); c2.Dump ("c2");

Console.WriteLine (c1.Real);       // 2
Console.WriteLine (c1.Imaginary);  // 3.5
Console.WriteLine (c1.Phase);      // 1.05165021254837
Console.WriteLine (c1.Magnitude);  // 4.03112887414927

Complex c3 = Complex.FromPolarCoordinates (1.3, 5);

// The standard arithmetic operators are overloaded to work on Complex numbers:
Console.WriteLine (c1 + c2);    // (5, 3.5)
Console.WriteLine (c1 * c2);    // (6, 10.5)

Complex.Atan (c1).Dump ("Atan");
Complex.Log10 (c1).Dump ("Log10");
Complex.Conjugate (c1).Dump ("Conjugate");
