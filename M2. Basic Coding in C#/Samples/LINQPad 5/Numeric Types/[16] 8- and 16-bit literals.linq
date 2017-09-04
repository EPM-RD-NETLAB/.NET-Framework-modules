<Query Kind="Statements" />

// The 8- and 16-bit integral types are byte, sbyte, short, and ushort. These types lack their
// own arithmetic operators, so C# implicitly converts them to larger types as required.
// This can cause a compile-time error when trying to assign the result back to a small integral type:

short x = 1, y = 1;
short z = x + y;          // Compile-time error

// In this case, x and y are implicitly converted to int so that the addition can be performed.
// To make this compile, we must add an explicit cast:

short z = (short) (x + y);   // OK