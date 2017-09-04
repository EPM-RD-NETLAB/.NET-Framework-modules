<Query Kind="Statements" />

// Integral conversions are implicit when the destination type can represent every possible value
// of the source type. Otherwise, an explicit conversion is required:

int x = 12345;       // int is a 32-bit integral
long y = x;          // Implicit conversion to 64-bit integral
short z = (short)x;  // Explicit conversion to 16-bit integral

// All integral types may be implicitly converted to all floating-point numbers:
int i = 1;
float f = i;

// The reverse conversion must be explicit:
int iExplicit = (int)f;

// Implicitly converting a large integral type to a floating-point type preserves magnitude but may
// occasionally lose precision:

int i1 = 100000001;
float f1 = i1;          // Magnitude preserved, precision lost
int i2 = (int)f1;       // 100000000