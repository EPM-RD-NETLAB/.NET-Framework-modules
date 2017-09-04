<Query Kind="Program" />

// Casting a struct to an interface causes boxing. Calling an implicitly implemented
// member on a struct does not cause boxing:

interface  I { void Foo();          }
struct S : I { public void Foo() {} }

static void Main()
{
	S s = new S();
	s.Foo();         // No boxing.
	
	I i = s;         // Box occurs when casting to interface.
	i.Foo();
}