<Query Kind="Program" />

// An overridden function member may seal its implementation with the sealed keyword to prevent it
// from being overridden by further subclasses:

static void Main()
{
	House mansion = new House { Name="McMansion", Mortgage=250000 };
	Console.WriteLine (mansion.Liability);      // 250000
}

public class Asset
{
	public string Name;
	public virtual decimal Liability { get { return 0; } }		// Virtual
}

public class House : Asset
{
	public decimal Mortgage;
	public sealed override decimal Liability { get { return Mortgage; } }   // Overridden + sealed
}

// You can also seal the class itself, implicitly sealing all the virtual functions:

public sealed class Stock : Asset { /* ... */ }