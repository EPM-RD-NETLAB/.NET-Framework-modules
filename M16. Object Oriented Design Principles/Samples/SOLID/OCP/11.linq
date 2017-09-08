<Query Kind="Program" />

class Client
{
	void Main()
	{
		var structure = new ObjectStructure();
		structure.Add(new ElementA());
		structure.Add(new ElementB());
		structure.Accept(new ConcreteVisitor1());
		structure.Accept(new ConcreteVisitor2());
	}
}

abstract class Visitor
{
	public abstract void VisitElementA(ElementA elemA);
	public abstract void VisitElementB(ElementB elemB);
}

class ConcreteVisitor1 : Visitor
{
	public override void VisitElementA(ElementA elementA)
	{
		elementA.OperationA();
	}
	public override void VisitElementB(ElementB elementB)
	{
		elementB.OperationB();
	}
}
class ConcreteVisitor2 : Visitor
{
	public override void VisitElementA(ElementA elementA)
	{
		elementA.OperationA();
	}
	public override void VisitElementB(ElementB elementB)
	{
		elementB.OperationB();
	}
}

class ObjectStructure
{
	List<Element> elements = new List<Element>();
	
	public void Add(Element element)
	{
		elements.Add(element);
	}
	
	public void Remove(Element element)
	{
		elements.Remove(element);
	}
	
	public void Accept(Visitor visitor)
	{
		foreach (Element element in elements)
			element.Accept(visitor);
	}
}

abstract class Element
{
	public abstract void Accept(Visitor visitor);
	public string SomeState { get; set; }
}

class ElementA : Element
{
	public override void Accept(Visitor visitor)
	{
		visitor.VisitElementA(this);
	}
	public void OperationA()
	{ }
}

class ElementB : Element
{
	public override void Accept(Visitor visitor)
	{
		visitor.VisitElementB(this);
	}
	public void OperationB()
	{ }
}