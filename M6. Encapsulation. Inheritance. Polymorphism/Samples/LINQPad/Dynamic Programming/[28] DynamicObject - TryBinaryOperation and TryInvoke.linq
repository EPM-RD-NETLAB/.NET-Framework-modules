<Query Kind="Program">
  
  <Namespace>System.Dynamic</Namespace>
</Query>

static void Main()
{
	dynamic d = new Duck();
	Console.WriteLine (d + d);          // foo
	Console.WriteLine (d (78, 'x'));    // 123
}

public class Duck : DynamicObject
{
	public override bool TryBinaryOperation (BinaryOperationBinder binder,
											object arg, out object result)
	{
		Console.WriteLine (binder.Operation);   // Add
		result = "foo";
		return true;
	}
	
	public override bool TryInvoke (InvokeBinder binder,
									object[] args, out object result)
	{
		Console.WriteLine (args[0]);    // 78
		result = 123;
		return true;
	}
}