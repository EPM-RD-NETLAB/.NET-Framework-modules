<Query Kind="Program" />

// You can also overload constructors.
// Note the use of the "this" keyword to call another constructor:

public class Wine
{
	public decimal Price;
	public int Year;
	public Wine (decimal price) { Price = price; }
	public Wine (decimal price, int year) : this (price) { Year = year; }
}

static void Main()
{
	new Wine (78).Dump();
	new Wine (78, 2001).Dump();
}