<Query Kind="Statements" />

// C#'s Definite Assignment policy means that local variables must be initialized before use.

int x;
Console.WriteLine (x);        // Compile-time error