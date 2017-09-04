<Query Kind="Statements" />

// Despite the Nullable<T> struct not defining operators such as <, >, or even ==, the 
// following code compiles and executes correctly, thanks to operator lifting:

int? x = 5;
int? y = 10;
{
	bool b = x < y;      // true
	b.Dump();
}
// The above line is equivalent to:
{
	bool b = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
	b.Dump();
}
