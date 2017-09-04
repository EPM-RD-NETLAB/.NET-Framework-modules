<Query Kind="Statements" />

// Three ways to create a Tuple:

var t1 = new Tuple<int,string> (123, "Hello");
Tuple<int,string> t2 = Tuple.Create (123, "Hello");
var t3 = Tuple.Create (123, "Hello");

t1.Dump(); t2.Dump(); t3.Dump();

Console.WriteLine (t1.Item1 * 2);         // 246
Console.WriteLine (t1.Item2.ToUpper());   // HELLO

// The alternative sacrafices static type safety and causes boxing with value types:

object[] items = { 123, "Hello" };
Console.WriteLine ( ((int)    items[0]) * 2       );   // 246
Console.WriteLine ( ((string) items[1]).ToUpper() );   // HELLO

