<Query Kind="Program">
  
</Query>

public class Foo<T> { public T Value; }

void Write (dynamic obj)
{
	try 
	{
		Console.WriteLine (obj.Value);
	}
	catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
	{
		"Member doesn't exist".Dump();
	}
}

void Main()
{
	Write (new Foo<int> { Value = 123 });
	Write (new Foo<string> { Value = "foo" });
}
