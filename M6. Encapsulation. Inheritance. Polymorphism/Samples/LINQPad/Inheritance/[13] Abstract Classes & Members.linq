<Query Kind="Program" />

// A class declared as abstract can never be instantiated. Instead, only its concrete subclasses
// can be instantiated. Abstract classes are able to define abstract members.

static void Main()
{
	new Stock { SharesOwned = 200, CurrentPrice = 123.45M }.NetValue.Dump();
}

public abstract class Asset		// Note abstract keyword
{
  	public abstract decimal NetValue { get; }	// Note empty implementation
}

public class Stock : Asset
{
	public long SharesOwned;
	public decimal CurrentPrice;

	public override decimal NetValue		// Override like a virtual method.
	{
		get { return CurrentPrice * SharesOwned; }
	}
}
