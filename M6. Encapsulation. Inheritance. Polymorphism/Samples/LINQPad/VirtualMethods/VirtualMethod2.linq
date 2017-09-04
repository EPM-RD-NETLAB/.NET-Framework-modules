<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
//	Shape s1 = new Circle(2.0); 
//	Console.WriteLine(s1.Area);
//	Shape s2 = new Square(3.0); 
//	Console.WriteLine(s2.Circumference);
	Circle c = new Circle(3.0); 
	Console.WriteLine(c.Radius);
	Shape s = c;
	Console.WriteLine(s.Area);
}

class Shape 
{
	public virtual double Area 
	{
		get { return 0.0; } 
	}
	public virtual double Circumference
	{
		get { return 0.0; } 
	}
}

class Circle : Shape 
{
	public Circle(double radius)
	{
		Radius = radius; 
	}
	public double Radius 
	{ 
		get; private set;
	}
	public override double Area 
	{
		get { return Math.PI * Radius * Radius; } 
	}
	public override double Circumference 
	{
		get { return Math.PI * 2 * Radius; } 
	}
}
class Square : Shape 
{
	public Square(double side) 
	{
		Side = side; 
	}
	public double Side 
	{ 
		get; private set;
	}
	public override double Area 
	{
		get { return Side * Side; } 
	}
	public override double Circumference 
	{
		get { return 4 * Side; } 
	}
}

