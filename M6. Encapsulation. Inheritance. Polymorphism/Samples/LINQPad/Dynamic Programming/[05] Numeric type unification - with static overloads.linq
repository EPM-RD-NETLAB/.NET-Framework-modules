<Query Kind="Program">
  
</Query>

static T Mean<T> (T x, T y)
{
	"Dynamic".Dump();
	dynamic result = ((dynamic) x + y) / 2;
	return (T) result;
}

static double Mean (double x, double y)
{
	"Static".Dump();
	return (x + y) / 2;
}

void Main()
{ 
	Mean (3, 4).Dump();
	Mean (3.0, 4.0).Dump();
}
