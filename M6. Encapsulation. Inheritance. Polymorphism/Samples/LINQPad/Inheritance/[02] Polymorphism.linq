<Query Kind="Program" />

// A variable of type x can refer to an object that subclasses x.

static void Main()
{
	// The Display method below accepts an Asset. This means means we can pass it any subtype:
	Display (new Stock { Name="MSFT", SharesOwned=1000 });
	Display (new House { Name="Mansion", Mortgage=100000 });
}

public static void Display (Asset asset)
{
	Console.WriteLine (asset.Name);
}

public class Asset
{
	public string Name;
}

public class Stock : Asset   // inherits from Asset
{
	public long SharesOwned;
}

public class House : Asset   // inherits from Asset
{
	public decimal Mortgage;
}