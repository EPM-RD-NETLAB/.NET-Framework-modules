<Query Kind="Program" />

// A static constructor executes once per type, rather than once per instance:

class Test
{
	static Test()
	{
		Console.WriteLine ("Type Initialized");
	}
}

static void Main()
{
	// Type is initialized only once
	new Test();
	new Test();
	new Test();
}