<Query Kind="Program" />

// The is operator tests whether a reference conversion (or unboxing conversion) would succeed:

static void Main()
{
	Asset a = new Asset();
	
	if (a is Stock)
  		Console.WriteLine (((Stock)a).SharesOwned);
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