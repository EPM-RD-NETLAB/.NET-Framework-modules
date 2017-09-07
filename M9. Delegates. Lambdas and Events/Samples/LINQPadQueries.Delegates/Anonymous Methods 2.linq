<Query Kind="Program" />

delegate void DelegateType();

static DelegateType GetMethod()
{
	return delegate () { System.Console.WriteLine("Hello"); };
}

static void Main()
{
	DelegateType delegateInstance = GetMethod();
	delegateInstance();
}