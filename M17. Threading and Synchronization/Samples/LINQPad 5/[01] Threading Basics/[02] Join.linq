<Query Kind="Program" />

static void Main()
{
	Thread t = new Thread (Go);
	t.Start();
	t.Join();
	Console.WriteLine ("Thread t has ended!");
}
 
static void Go() 
{
	for (int i = 0; i < 1000; i++) Console.Write ("y"); 
}