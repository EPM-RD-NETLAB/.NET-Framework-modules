<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	ExampleClass ec = new ExampleClass();
	Console.WriteLine(ec.exampleMethod(10));
	Console.WriteLine(ec.exampleMethod("value"));

	Console.WriteLine(ec.exampleMethod(10, 4));//CTE

	dynamic dynamic_ec = new ExampleClass();
	Console.WriteLine(dynamic_ec.exampleMethod(10));

	Console.WriteLine(dynamic_ec.exampleMethod(10, 4));//RTE
}
class ExampleClass
{
	static dynamic field; 
	dynamic prop { get; set; }

	public dynamic exampleMethod(dynamic d)
	{
		dynamic local = "Local variable";
		int two = 2;
		if (d is int)
		{ 
			return local;
		}
		else 
		{ 
			return two;
		}
	}
}