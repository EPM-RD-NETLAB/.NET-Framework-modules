<Query Kind="Statements" />

class X { }

class B { }

class D : B
{
	public static void X() { }

	public static void Y()
	{
		X();
	}
}