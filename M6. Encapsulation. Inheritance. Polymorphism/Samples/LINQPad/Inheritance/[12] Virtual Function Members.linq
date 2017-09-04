<Query Kind="Program" />

// A function marked as virtual can be overridden by subclasses wanting to provide a specialized implementation:

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
	public override decimal Liability { get { return Mortgage; } }   // Overridden
}

public class Stock : Asset
{
	public long SharesOwned;
	// We won't override Liability here, because the default implementation will do.
}
