<Query Kind="Program" />

interface IDraw
{
	void Draw();
}

public class BaseClass : IDraw
{
	void IDraw.Draw()
	{
		Console.WriteLine("Explicit interface method implementation");
	}
}
public class DerivedClass : BaseClass, IDraw
{
	public void Draw()
	{
		Console.WriteLine("Implicit interface mathod implemantation");
	}
}

void Main()
{
	BaseClass baseClass = new BaseClass();
    ((IDraw)baseClass).Draw();
	DerivedClass derivedClass = new DerivedClass();
	derivedClass.Draw();
	baseClass = derivedClass;
	((IDraw)baseClass).Draw();
	IDraw draw = new BaseClass();
	draw.Draw();
	draw = new DerivedClass();
	draw.Draw();	
}