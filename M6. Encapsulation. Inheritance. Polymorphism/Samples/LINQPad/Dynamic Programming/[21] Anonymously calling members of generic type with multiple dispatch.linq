<Query Kind="Program">
  
</Query>

public class Foo<T> { public T Value; }

void Write (dynamic obj)
{
	object result = GetFooValue (obj);
	if (result != null) Console.WriteLine (result);
}

static T GetFooValue<T> (Foo<T> foo) { return foo.Value; }
static object GetFooValue (object foo) { return null; }

void Main()
{
	Write (new Foo<int> { Value = 123 });
	Write (new Foo<string> { Value = "foo" });
}
