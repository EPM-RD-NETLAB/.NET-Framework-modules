<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void Main()
{
	var task = Task.Factory.StartNew (Greet, "Hello");
}

static void Greet (object state) { Console.Write (state); }   // Hello