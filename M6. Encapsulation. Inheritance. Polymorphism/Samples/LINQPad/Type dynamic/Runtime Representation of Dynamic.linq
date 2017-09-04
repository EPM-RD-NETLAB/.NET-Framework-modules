<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

// The following expression is true, although the compiler does not permit it:
//typeof (dynamic) == typeof (object));

// This principle extends to constructed types and array types:
(typeof (List<dynamic>) == typeof (List<object>)).Dump();		// True

(typeof (dynamic[]) == typeof (object[])).Dump();		// True

// Like an object reference, a dynamic reference can point to an object of any type
//(except pointer types):

dynamic x = "hello";
Console.WriteLine (x.GetType().Name);  // String

x = 123;  // No error (despite same variable)
Console.WriteLine (x.GetType().Name);  // Int32

// You can convert from object to dynamic to perform any dynamic operation you want on an object:
object o = new System.Text.StringBuilder();
dynamic d = o;
d.Append ("hello");
Console.WriteLine (o);   // hello