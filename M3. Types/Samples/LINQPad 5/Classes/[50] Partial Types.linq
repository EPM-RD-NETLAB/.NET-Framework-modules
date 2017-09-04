<Query Kind="Program" />

// Partial types allow a type definition to be split—typically across multiple files:

partial class PaymentForm { public int X; }
partial class PaymentForm { public int Y; }

static void Main()
{
	new PaymentForm { X = 3, Y = 4 }.Dump();
}