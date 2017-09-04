<Query Kind="Program" />

void Main()
{
	SomeClass obj = new SomeClass();
	obj.ToString();
}

class SomeClass
{
	public override string ToString()
	{
		return base.ToString();
	}
}