<Query Kind="Program" />

// The as operator performs a downcast that evaluates to null (rather than throwing an exception)
// if the downcast fails.

static void Main()
{
	Asset a = new Asset();
	Stock s = a as Stock;       // s is null; no exception thrown

	if (s != null) Console.WriteLine (s.SharesOwned);	// Nothing written
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