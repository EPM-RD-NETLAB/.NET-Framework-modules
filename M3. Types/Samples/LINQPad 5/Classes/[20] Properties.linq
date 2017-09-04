<Query Kind="Program" />

// Properties look like fields from the outside but internally, they contain logic, like methods:

public class Stock
{
	decimal currentPrice;           // The private "backing" field
	
	public decimal CurrentPrice     // The public property
	{
		get { return currentPrice; } set { currentPrice = value; }
	}
}

static void Main()
{		
	var stock = new Stock();
	stock.CurrentPrice = 123.45M;
	stock.CurrentPrice.Dump();
	
	var stock2 = new Stock { CurrentPrice = 83.12M };
	stock2.CurrentPrice.Dump();
}