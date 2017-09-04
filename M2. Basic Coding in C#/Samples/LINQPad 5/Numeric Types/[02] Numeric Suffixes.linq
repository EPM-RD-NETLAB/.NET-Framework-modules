<Query Kind="Statements" />

// Numeric literals can be suffixed with a character to indicate their type:
//   F = float
//   D = double
//   M = decimal
//   U = uint
//   L = long
//   UL = ulong

long i = 5;     // No suffix needed: Implicit lossless conversion from int literal to long

// The D suffix is redundant in that all literals with a decimal point are inferred to be double:
double x = 4.0;

// The F and M suffixes are the most useful:
float f = 4.5F;			// Will not compile without the F suffix
decimal d = -1.23M;		// Will not compile without the M suffix.