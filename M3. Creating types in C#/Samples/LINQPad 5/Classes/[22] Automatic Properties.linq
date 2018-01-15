<Query Kind="Program" />

// Here's the preceding example rewritten with two automatic properties:

public class Stock
{
	public decimal CurrentPrice { get; set; }	// Automatic property
	public decimal SharesOwned { get; set; }    // Automatic property

	public decimal Worth
	{
		get { return CurrentPrice * SharesOwned; }
	}
}

static void Main()
{		
	var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };
	stock.Worth.Dump();
}