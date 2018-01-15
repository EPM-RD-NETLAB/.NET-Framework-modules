<Query Kind="Statements" />

// The ?? operator is the null coalescing operator, and it can be used with both 
// nullable types and reference types. It says “If the operand is non-null, give
// it to me; otherwise, give me a default value.”:

int? x = null;
int y = x ?? 5;
Console.WriteLine (y);	// 5

int? a = null, b = 1, c = 2;
Console.WriteLine (a ?? b ?? c);  // 1 (first non-null value)
