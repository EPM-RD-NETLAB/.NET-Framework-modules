<Query Kind="Program">
  <Namespace>System.Dynamic</Namespace>
</Query>

// Static types are also used — wherever possible — in dynamic binding:

static void Foo (object x, object y) { Console.WriteLine ("oo"); }
static void Foo (object x, string y) { Console.WriteLine ("os"); }
static void Foo (string x, object y) { Console.WriteLine ("so"); }
static void Foo (string x, string y) { Console.WriteLine ("ss"); }

static void Main()
{
	object o = "hello";
	dynamic d = "goodbye";
	Foo (o, d);               
}