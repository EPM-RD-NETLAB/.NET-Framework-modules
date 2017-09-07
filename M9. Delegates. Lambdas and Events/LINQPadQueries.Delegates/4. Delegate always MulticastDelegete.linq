<Query Kind="Program" />

//MulticastDelegate!
delegate void Delegate();

static void Method() { }

static void Main()
{
	Delegate del = new Delegate(Method);
	Console.WriteLine(del.GetType().BaseType.Name);
}
