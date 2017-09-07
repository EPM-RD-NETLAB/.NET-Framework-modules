<Query Kind="Statements" />

string captured = "before x is created";

Action x = delegate
{
   Console.WriteLine(captured);
   captured = "changed by x";
};
//x.Dump();
captured = "directly before x is invoked";
//x.Dump();
x();
Console.WriteLine(captured);

captured = "before second invocation";
x();
Console.WriteLine(captured);