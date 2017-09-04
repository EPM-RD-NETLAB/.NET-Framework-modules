<Query Kind="Program" />

void Main()
{
	Human h = new Human();
	Mammal m = h;
	
	h.age = 10;
	m.age = 20;

	h.Foo(12);

	h.Dump();
	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}

public abstract class Mammal
{
	public int age;
	public static int count;
	public abstract void Foo(int count);
}

public class Human : Mammal
{
	public new int age;
	//ключевое слово new никак не затрагивает метаданные 
	//или выполняемый код!!!
	public new static int count;
	
	public override void Foo(int count)
	{
		Console.WriteLine(++age);
		Console.WriteLine(++this.age);
		Console.WriteLine(++base.age);
		Console.WriteLine(++count);
		Console.WriteLine(++Mammal.count);
		Console.WriteLine(++Human.count);
	}
}

public class Human1 : Human
{
	public sealed override void Foo(int count)
	{
		Console.WriteLine(++age);
		Console.WriteLine(++this.age);
		Console.WriteLine(++base.age);
		Console.WriteLine(++count);
		Console.WriteLine(++Mammal.count);
		Console.WriteLine(++Human.count);
	}
}