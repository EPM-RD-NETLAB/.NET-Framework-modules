<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

dynamic d;
int i = 20;
d = i;
Console.WriteLine(d);
Console.WriteLine(d.GetType());

string s = "Example string.";
d = s;
Console.WriteLine(d);
Console.WriteLine(d.GetType());

DateTime dt = DateTime.Today;
d = dt;
Console.WriteLine(d);
Console.WriteLine(d.GetType());