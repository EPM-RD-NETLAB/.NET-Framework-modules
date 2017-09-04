<Query Kind="Program" />

interface IDraw
{
	void Draw();
}

public class BaseClass : IDraw
{
	public virtual void Draw()
	{
		Console.WriteLine("In BaseClass Implicit implementation method interface IDraw");
	}
}
public class DerivedClass : BaseClass
{
	public override void Draw()
	{ 
		Console.WriteLine("In DerivedClass Implicit implementation method interface IDraw");
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