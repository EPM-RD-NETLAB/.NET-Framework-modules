<Query Kind="Program" />

void Main()
{
	Human h = new Human();
	Mammal m = h;
	
	h.age = 10;
	m.age = 20;
	
	h.Dump();
}

public abstract class Mammal
{
	public int age;
	public static int count;
}

public class Human : Mammal
{
	//field name collision
	
	public int age;
	public static int count;
	
	public void Foo(int count)
	{
		++age;
		++this.age;
		++base.age;
		++count;
		++Mammal.count;
		++Human.count;
	}
}
