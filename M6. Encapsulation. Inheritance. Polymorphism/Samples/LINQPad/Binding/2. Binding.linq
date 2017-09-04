<Query Kind="Program" />

void Main()
{

}

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