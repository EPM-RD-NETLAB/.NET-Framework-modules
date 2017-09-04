<Query Kind="Statements" />

// Lifted equality operators handle nulls just like reference types do:

Console.WriteLine (       null ==        null);   // True
Console.WriteLine ((bool?)null == (bool?)null);   // True
