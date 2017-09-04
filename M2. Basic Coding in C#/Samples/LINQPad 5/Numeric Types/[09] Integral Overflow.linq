<Query Kind="Statements" />

// By default, integral arithmetic operations overflow silently:

int a = int.MinValue;
a--;
Console.WriteLine (a == int.MaxValue);  // True