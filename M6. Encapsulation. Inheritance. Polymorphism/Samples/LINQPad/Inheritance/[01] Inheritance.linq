<Query Kind="Program" />

// A class can inherit from another class to extend or customize the original class.

static void Main()
{
	Stock msft = new Stock { Name="MSFT", SharesOwned=1000 };

	Console.WriteLine (msft.Name);         // MSFT
	Console.WriteLine (msft.SharesOwned);  // 1000
	
	House mansion = new House { Name="Mansion", Mortgage=250000 };
	
	Console.WriteLine (mansion.Name);      // Mansion
	Console.WriteLine (mansion.Mortgage);  // 250000
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