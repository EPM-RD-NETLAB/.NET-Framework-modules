<Query Kind="Program" />

//Aактически реальные делегаты всегда являются наследниками MulticastDelegate!
delegate void Delegate();

static void Method() { }

static void Main()
{
	Delegate del = new Delegate(Method);
	Console.WriteLine(del.GetType().BaseType.Name);
}