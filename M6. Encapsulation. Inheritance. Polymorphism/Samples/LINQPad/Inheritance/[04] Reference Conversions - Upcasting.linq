<Query Kind="Program" />

static void Main()
{
	// An upcast creates a base class reference from a subclass reference:
	
	Stock msft = new Stock();
	Asset a = msft;             	// Upcast
	
	// After the upcast, the two variables still references the same Stock object:
	
	Console.WriteLine (a == msft);	// True
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