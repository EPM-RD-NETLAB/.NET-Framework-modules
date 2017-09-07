<Query Kind="Program" />

// The simplest solution is to instead use the as operator, which is unambiguous because it cannot perform custom conversions:

StringBuilder Foo<T> (T arg)
{
	StringBuilder sb = arg as StringBuilder;
	if (sb != null) return sb;
	
	/*...*/
	return null;
}

static void Main()
{
}
