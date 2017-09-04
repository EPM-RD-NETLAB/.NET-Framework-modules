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
	
public class DerivedClass : BaseClass
{
	public void Draw()
	{
		Console.WriteLine("Not a method of interface");
	}
}

void Main()
{
	BaseClass baseClass = new BaseClass();
	//baseClass.Draw();//CTE     
	DerivedClass derivedClass = new DerivedClass();
	derivedClass.Draw();
	baseClass = derivedClass;
	//baseClass.Draw();//CTE
	IDraw draw = new BaseClass();
	draw.Draw();
	draw = new DerivedClass();
	draw.Draw();
}
