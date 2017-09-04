<Query Kind="Program" />

static void Main()
{
	Overrider over = new Overrider();
	BaseClass b1 = over;
	over.Foo();                         // Overrider.Foo
	b1.Foo();                           // Overrider.Foo
	
	Hider h = new Hider();
	BaseClass b2 = h;
	h.Foo();                           // Hider.Foo
	b2.Foo();                          // BaseClass.Foo
}

public class BaseClass
{
	public virtual void Foo()  { Console.WriteLine ("BaseClass.Foo"); }
}

public class Overrider : BaseClass
{
 	public override void Foo() { Console.WriteLine ("Overrider.Foo"); }
}

public class Hider : BaseClass
{
	public new void Foo()      { Console.WriteLine ("Hider.Foo"); }
}
