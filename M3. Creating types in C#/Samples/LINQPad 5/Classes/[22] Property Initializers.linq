<Query Kind="Program" />

public decimal CurrentPrice { get; set; } = 123;
public int Maximum { get; } = 999;

void Main()
{
	CurrentPrice.Dump();
	Maximum.Dump();
}