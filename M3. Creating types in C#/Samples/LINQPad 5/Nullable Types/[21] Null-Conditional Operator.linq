<Query Kind="Statements" />

// Nullable types also work well with the null-conditional operator (see “Null-Conditional Operator”)

System.Text.StringBuilder sb = null;
int? length = sb?.ToString().Length;
length.Dump();

// We can combine this with the null coalescing operator to evaluate to zero instead of null:

int length2 = sb?.ToString().Length ?? 0;  // Evaluates to 0 if sb is null
length2.Dump();
