<Query Kind="Program" />

delegate void DelegateType();

static void Main()
{
	DelegateType delegateInstance = delegate() { Console.WriteLine("Hello"); };
	delegateInstance += delegate { Console.WriteLine("Bonjour"); };
	delegateInstance -= delegate { Console.WriteLine("Bonjour"); };
	delegateInstance();
}