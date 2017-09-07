<Query Kind="Program" />

// Delegate instances are considered equal if they have the same method targets:

delegate void D();

static void Main()
{
	D d1 = Method1;
	D d2 = Method1;
	Console.WriteLine (d1 == d2);         // True
	A a = new A();
	
	d1 = a.Do;
	d2 = a.Do;
	Console.WriteLine (d1 == d2);         // True
}

class A
{
	public void Do() {}
}
static void Method1() { }