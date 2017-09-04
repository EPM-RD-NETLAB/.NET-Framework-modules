<Query Kind="Program" />

interface IDraw
{
	void Draw();
}

public class BaseClass : IDraw
{
	public void Draw()
	{
		Console.WriteLine("Implicit implementation method interface IDraw");
	}
}

public class DerivedClass : BaseClass, IDraw
{
	//public override void Draw(){}//CTE
	public new void Draw()
	{
		Console.WriteLine("Hiding method (interface) of base class");
	}
}

void Main()
{
	BaseClass baseClass = new BaseClass();
 	baseClass.Draw();     
 	DerivedClass derivedClass = new DerivedClass();
	derivedClass.Draw();
	baseClass = derivedClass;
	baseClass.Draw();	
	IDraw draw = new BaseClass();
	draw.Draw();
	draw = new DerivedClass();
	draw.Draw();
}