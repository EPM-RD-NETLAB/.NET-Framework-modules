<Query Kind="Program" />

void Main()
{
	Base d = new Derived();
}

class Base
{
	public int x = 12;
	public Base()
	{
		x.Dump();
		x = 13;
		"Base->ctor".Dump();
	}
}

class Derived : Base
{
	public int x = 122;
	public Derived()
	{
		x.Dump();
		x = 133;
		"Derived->ctor".Dump();
	}
}