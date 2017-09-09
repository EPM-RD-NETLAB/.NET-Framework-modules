<Query Kind="Program" />

//Паттерн «Посетитель» показывает функциональный подход к 
//расширяемости семейства типов. В функциональном 
//программировании операции четко отделены от данных. 
//Свободные функции принимают на входе экземпляр
//неизменяемого типа данных и вычисляют результат в
//зависимости от типа. При этом добавить новую функцию 
//очень просто, но добавление нового варианта в семейство 
//типов может потребовать множества изменений.

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
	public abstract void Accept(IShapeVisitor visitor);
}

public class Circle : Shape
{
	public double Radius { get; set; }
	public override void Accept(IShapeVisitor visitor)
	{
		visitor.Visit(this);
	}
}

public class Square : Shape
{
	public double X { get; set; }
	public override void Accept(IShapeVisitor visitor)
	{
		visitor.Visit(this);
	}
}

public class Rectangle : Shape
{
	public double X { get; set; }
	public double Y { get; set; }
	public override void Accept(IShapeVisitor visitor)
	{
		visitor.Visit(this);
	}
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

public class ComputePerVisitor : IShapeVisitor
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

	public static double GetPer(this Shape shape)
	{
		var visitor = new ComputePerVisitor();
		shape.Accept(visitor);
		return visitor.Area;
	}
}