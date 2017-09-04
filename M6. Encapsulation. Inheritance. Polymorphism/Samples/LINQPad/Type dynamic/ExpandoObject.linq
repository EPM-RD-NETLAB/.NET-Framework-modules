<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <Namespace>System.Dynamic</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

dynamic x = new ExpandoObject();
x.Foo = "Hi!";
x.st = 12;
((IDictionary<string,object>)x).Dump();