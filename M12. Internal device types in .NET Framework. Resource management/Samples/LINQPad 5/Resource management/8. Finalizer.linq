<Query Kind="Program" />

void Main()
{
	var program = new Program();
	program.InstanceMethod();
}

internal class Program
{
	~Program()
	{
		Print("Program.dtor");
	}

	public static void Print(string message)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Console.WriteLine(message);
	}

	public void InstanceMethod()
	{
		Console.WriteLine("Instance method began");
		Print("Instance method finished");
	}
}