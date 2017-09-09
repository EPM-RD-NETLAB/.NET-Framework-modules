<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static Barrier _barrier = new Barrier (3);

static void Main()
{
	new Thread (Speak).Start();
	new Thread (Speak).Start();
	new Thread (Speak).Start();
}

static void Speak()
{
	for (int i = 0; i < 5; i++)
	{
		Console.Write (i + " ");
		_barrier.SignalAndWait();
	}
}
