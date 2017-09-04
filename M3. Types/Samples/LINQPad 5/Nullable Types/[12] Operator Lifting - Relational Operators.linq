<Query Kind="Statements" />

// The relational operators work on the principle that it is meaningless to compare null operands:

int? x = 5;
int? y = null;
{
	bool b = x < y;
	b.Dump();
}

// Translation:
{
	bool b = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
	b.Dump();
}