<Query Kind="Program" />

//могут добавляться как классы в иерархию наследования,
//так и операции в иерархию наследования

void Main()
{
	Shape shape = new Circle();
	var area = shape.GetArea();
	shape = new Rectangle();
	area = shape.GetArea();
	shape = new Square();
	area = shape.GetArea();
}

public interface IShapeVisitor
{
	void Visit(Circle circle);
	void Visit(Square square);
	void Visit(Rectangle rectangle);
}

public abstract class Shape
{
	public virtual void Accept(IShapeVisitor visitor)
	{
		visitor.Visit((dynamic)this);
	}
}

public class Circle : Shape
{
	public double Radius { get; set; }
}

public class Square : Shape
{
	public double X { get; set; }
}

public class Rectangle : Shape
{
	public double X { get; set; }
	public double Y { get; set; }
}

public class ComputeAreaVisitor : IShapeVisitor
{
	public double Area { get; private set; }

	public void Visit(Circle circle)
	{
		Area = Math.PI * Math.Sqrt(circle.Radius);
		"Circle area".Dump();
	}
	public void Visit(Square square)
	{
		Area = Math.Sqrt(square.X);
		"Square area".Dump();
	}
	public void Visit(Rectangle rectangle)
	{
		Area = rectangle.X * rectangle.Y;
        "Rectangle area".Dump();
	}
}

public static class ShapeExtensions
{
	public static double GetArea(this Shape shape)
	{
		var visitor = new ComputeAreaVisitor();
		shape.Accept(visitor);
		return visitor.Area;
	}
}

//http://blogs.msdn.com/b/laurionb/archive/2009/05/29/implementing-the-visitor-pattern-with-the-dynamic-feature-of-c-4-0.aspx
//http://odetocode.com/blogs/scott/archive/2008/03/10/visitors-and-multiple-dispatch.aspx