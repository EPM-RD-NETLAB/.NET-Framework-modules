<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\UIAutomationProvider.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\UIAutomationTypes.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\ReachFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationUI.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\System.Printing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Namespace>System.Windows.Shapes</Namespace>
</Query>

#region Расширяемость: объектно-ориентированный и функциональный подходы

#endregion

//структурный подход
public enum ShapeType
{
	Circle,
	Square,
	Rectangle
	//etc
}

public static void DrawShape(Shape shape)
{
	switch (shape.ShapeType)
	{
		case ShapeType.Circle:
			DrawCircle((Circle)shape);
			break;
		case ShapeType.Square:
			DrawSquare((Square)shape);
			break;
		case ShapeType.Rectangle:
			DrawRectangle((Rectangle)shape);
			break;
		default:
			throw new InvalidOperationException("Unknown shape!");
	}
}

//vs объектно-оиентированный подход

public abstract class Shape
{
	public abstract void Draw();

}

public class Circle : Shape
{
	public double Radius { get; set; }
	public override void Draw() { }
}

public class Square : Shape
{
	public double X { get; set; }
	public override void Draw() { }
}

public class Rectangle : Shape
{
	public double X { get; set; }
	public double Y { get; set; }
	public override void Draw() { }
}

public static void DrawShape(Shape shape)
{
	shape.Draw();
}

#region Problem
//Добавить новый класс в иерархию фигур довольно легко, но что, 
//если мы хотим добавить новую операцию, например метод GetArea? 
//Добавление нового абстрактного метода в класс Shape является 
//«ломающим» изменением (breaking change) и потребует 
//изменения всех классов наследников.

//Объектно-ориентированное решение на основе полиморфизма позволяет
//легко расширять функциональность лишь в определенном направлении, 
//но не является открытым к любым изменениям. Задача добавления 
//новой операции в существующую иерархию типов решается с помощью 
//паттерна «Посетитель(Visitor)».
#endregion
