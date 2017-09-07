<Query Kind="Program" />

// A type can name itself as the concrete type when closing a type argument:

public class Balloon : IEquatable<Balloon>
{
	public string Color { get; set; }
	public int CC { get; set; }
	
	public bool Equals (Balloon b)
	{
		if (b == null) return false;
		return b.Color == Color && b.CC == CC;
	}
	
	// In real life, we would override object.Equals / GetHashCode as well - see Chapter 6.
}

static void Main()
{
	var b1 = new Balloon { Color = "Red", CC = 123 };
	var b2 = new Balloon { Color = "Red", CC = 123 };
	
	b1.Equals (b2).Dump();
}
