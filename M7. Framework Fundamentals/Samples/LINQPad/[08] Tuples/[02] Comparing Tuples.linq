<Query Kind="Statements" />

var t1 = Tuple.Create (123, "Hello");
var t2 = Tuple.Create (123, "Hello");

Console.WriteLine (t1 == t2);           // False
Console.WriteLine (t1.Equals (t2));     // True
