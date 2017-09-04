<Query Kind="Program" />

static void Main()
{
	// A downcast operation creates a subclass reference from a base class reference.
	
	Stock msft = new Stock();
	Asset a = msft;                      // Upcast
	Stock s = (Stock)a;                  // Downcast
	Console.WriteLine (s.SharesOwned);   // <No error>
	Console.WriteLine (s == a);          // True
	Console.WriteLine (s == msft);       // True
	
	// A downcast requires an explicit cast because it can potentially fail at runtime:
	
	House h = new House();
	Asset a2 = h;               // Upcast always succeeds
	Stock s2 = (Stock)a2;       // ERROR: Downcast fails: a is not a Stock
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