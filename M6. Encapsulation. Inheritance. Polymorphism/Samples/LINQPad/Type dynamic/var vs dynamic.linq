<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

// var says, “let the compiler figure out the type”.
// dynamic says, “let the runtime figure out the type”.

dynamic x = "hello";  // Static type is dynamic, runtime type is string
var y = "hello";      // Static type is string, runtime type is string
int i = x;            // Run-time error
int j = y;            // Compile-time error