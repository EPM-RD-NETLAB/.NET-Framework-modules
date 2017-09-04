<Query Kind="Statements" />

// Compile-time overflows are special in that they're checked by default:

int x = int.MaxValue + 1;               // Compile-time error

// You have to use unchecked to disable this:

int y = unchecked (int.MaxValue + 1);   // No errors