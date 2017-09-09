<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void Main()
{
	var task = Task.Factory.StartNew (state => Greet ("Hello"), "Greeting");
	Console.WriteLine (task.AsyncState);   // Greeting
}

static void Greet (string message) { Console.WriteLine (message); }