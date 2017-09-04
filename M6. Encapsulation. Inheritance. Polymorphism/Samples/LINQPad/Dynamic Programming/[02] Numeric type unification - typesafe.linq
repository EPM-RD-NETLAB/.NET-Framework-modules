<Query Kind="Program">
  
</Query>

static T Mean<T> (T x, T y)
{
	dynamic result = ((dynamic) x + y) / 2;
	return (T) result;
}

void Main()
{ 
	int x = 3, y = 5;
	Console.WriteLine (Mean (x, y));
}
