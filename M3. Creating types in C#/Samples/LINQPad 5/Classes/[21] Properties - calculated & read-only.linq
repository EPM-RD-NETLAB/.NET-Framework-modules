<Query Kind="Program" />

// The Worth Property is a read-only calculated property.

public class Stock
{
	decimal currentPrice;           // The private "backing" field
	public decimal CurrentPrice     // The public property
	{
		get { return currentPrice; } set { currentPrice = value; }
	}

	decimal sharesOwned;           // The private "backing" field
	public decimal SharesOwned     // The public property
	{
		get { return sharesOwned; } set { sharesOwned = value; }
	}

	public decimal Worth
	{
		get { return currentPrice * sharesOwned; }
	}
}

static void Main()
{		
	var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };
	stock.Worth.Dump();
}