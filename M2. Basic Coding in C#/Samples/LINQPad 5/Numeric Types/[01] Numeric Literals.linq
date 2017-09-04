<Query Kind="Statements" />

// Integral literals can use decimal or hexadecimal notation; hexadecimal is denoted with the 0x prefix:
int x = 127;
long y = 0x7F;

//Real literals can use decimal and/or exponential notation. For example:
double d = 1.5;
double million = 1E06;

// Numeric literal type inference:
Console.WriteLine (       1.0.GetType());  // Double  (double)
Console.WriteLine (      1E06.GetType());  // Double  (double)
Console.WriteLine (         1.GetType());  // Int32   (int)
Console.WriteLine (0xF0000000.GetType());  // UInt32  (uint)
Console.WriteLine (0x100000000.GetType());  // Int64   (long)