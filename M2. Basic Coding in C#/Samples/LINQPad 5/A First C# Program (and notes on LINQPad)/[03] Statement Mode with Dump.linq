<Query Kind="Statements" />

int x = 12 * 30;			  // Statement 1
Console.WriteLine (x);		  // Statement 2

// Another way to call Console.WriteLine in LINQPad is to call the .Dump() extension method:
x.Dump();

// Both Console.WriteLine and the Dump method give rich formatting in LINQPad - automatically
// expanding objects and collections.