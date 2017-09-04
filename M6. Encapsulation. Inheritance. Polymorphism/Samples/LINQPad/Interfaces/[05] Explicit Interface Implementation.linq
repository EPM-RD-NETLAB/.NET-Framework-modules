<Query Kind="Program" />

// Implementing multiple interfaces can sometimes result in a collision between member signatures.
// You can resolve such collisions by explicitly implementing an interface member:

interface I1 { void Foo(); }
interface I2 { int Foo(); }

public class Widget : I1, I2
{
	public void Foo ()
	{
		Console.WriteLine ("Widget's implementation of I1.Foo");
	}
	
	int I2.Foo()
	{
		Console.WriteLine ("Widget's implementation of I2.Foo");
		return 42;
	}
}

static void Main()
{
	Widget w = new Widget();
	w.Foo();                      // Widget's implementation of I1.Foo
	((I1)w).Foo();                // Widget's implementation of I1.Foo
	((I2)w).Foo();                // Widget's implementation of I2.Foo
}

// Another reason to explicitly implement interface members is to hide members that are
// highly specialized and distracting to a type’s normal use case.


