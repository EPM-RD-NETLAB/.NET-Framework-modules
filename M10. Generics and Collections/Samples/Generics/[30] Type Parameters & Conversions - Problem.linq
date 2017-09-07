<Query Kind="Program" />

// The most common scenario is when you want to perform a reference conversion:

StringBuilder Foo<T> (T arg)
{
	if (arg is StringBuilder)
		return (StringBuilder) arg;   // Will not compile: Cannot convert T to StringBuilder
	
	/*...*/
	return null;
}

static void Main()
{
}
