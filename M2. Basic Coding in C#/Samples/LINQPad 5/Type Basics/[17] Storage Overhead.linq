<Query Kind="Program" />

// Structs take up as much room as their fields:
struct Point
{
	int x;  // 4 bytes
	int y;  // 4 bytes
}

// However, the CLR requires that fields are offset within the type at an address
// that’s a multiple of their size:
struct A
{
	byte b;  // 1 byte
	long l;  // 8 bytes
}

unsafe static void Main()
{
	sizeof (Point).Dump();	// 8 bytes
	sizeof (A).Dump();		// 16 bytes
}