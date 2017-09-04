<Query Kind="Program" />

// If a constructor in a subclass omits the base keyword, the base type’s parameterless
// constructor is implicitly called:

static void Main()
{
	new Subclass();
}

public class BaseClass
{
	public int X;
	public BaseClass() { X = 1; }
}

public class Subclass : BaseClass
{
	public Subclass() { Console.WriteLine (X); }  // 1
}
