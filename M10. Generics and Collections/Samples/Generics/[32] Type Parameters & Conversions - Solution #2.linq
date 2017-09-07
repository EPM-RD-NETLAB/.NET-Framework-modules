<Query Kind="Program" />

// A more general solution is to first cast to object:

StringBuilder Foo<T> (T arg)
{
	if (arg is StringBuilder)
		return (StringBuilder) (object) arg;
	
	/*...*/
	return null;
}

static void Main()
{
}
