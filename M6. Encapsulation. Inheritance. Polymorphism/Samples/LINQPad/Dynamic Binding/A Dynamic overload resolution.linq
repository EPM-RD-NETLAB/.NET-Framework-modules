<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	dynamic d = "string";
	var i = 12;
	object o = "string";
	Foo(i);
	Foo (d);
	Foo (o);
}

void Foo (int x) => Console.WriteLine ("integer");
void Foo (string x) => Console.WriteLine ("string"); 
//void Foo (object x)	=> Console.WriteLine ("object");//CTE object == dynamic for compiler
void Foo (dynamic x)	=> Console.WriteLine ("dynamic");