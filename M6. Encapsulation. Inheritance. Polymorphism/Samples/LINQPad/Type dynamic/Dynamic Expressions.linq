<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

// Trying to consume the result of a dynamic expression with a void return type is
// prohibited — just as with a statically typed expression. However, the error occurs at runtime:

dynamic list = new List<int>();
var result = list.Add (5);         // RuntimeBinderException thrown

// Expressions involving dynamic operands are typically themselves dynamic:
dynamic x = 2;
var y = x * 3;       // Static type of y is dynamic

// However, casting a dynamic expression to a static type yields a static expression:
dynamic a = 2;
var b = (int)2;      // Static type of b is int

// And constructor invocations always yield static expressions:
dynamic capacity = 10;
var sb = new System.Text.StringBuilder (capacity);
int len = sb.Length;