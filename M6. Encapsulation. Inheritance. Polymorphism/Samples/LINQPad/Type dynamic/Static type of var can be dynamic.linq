<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

// The static type of a variable declared of type var can be dynamic:

dynamic x = "hello";
var y = x;            // Static type of y is dynamic
int z = y;            // Run-time error