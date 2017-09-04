<Query Kind="Program" />

void Main()
{
	Human h = new Human();
	Mammal m = h;
	
	h.age = 10;
	m.age = 20;
	
	h.Dump();
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

public abstract class Mammal
{
	public int age;
	public static int count;
}

public class Human : Mammal
{
	//сценарий коллизии имен полей
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