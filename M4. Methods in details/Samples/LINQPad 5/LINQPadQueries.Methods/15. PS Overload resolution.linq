<Query Kind="Program" />

//Overload resolution

class Dog
{
	public void Bark(string sound)
	{
		Console.WriteLine("1 - " + sound);
	}
	public void Bark(string sound, int times = 1)
	{
		for(int i = 0; i < times; i++)
		{
			Console.WriteLine(sound);
		}
	}
}

void Main()
{
	var d = new Dog();
	d.Bark("Woof");
	"----".Dump();
	d.Bark("Woof", 4);
}

// Least surprize principle