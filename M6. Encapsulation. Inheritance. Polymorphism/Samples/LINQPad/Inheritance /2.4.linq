<Query Kind="Program" />

interface IDraw
{
	void Draw();
}

public class BaseClass : IDraw
{
	public void Draw()
	{
		Console.WriteLine("In BaseClass Implicit implementation method interface IDraw");
	}
}

public class DerivedClass : BaseClass
{
	//public override void Draw(){}//CTE - method Draw not virtual!
	public new void Draw()
	{
		Console.WriteLine("Hiding method (interface) in DerivedClass of base class BaseClass");
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