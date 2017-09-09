<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static ThreadLocal<int> _x = new ThreadLocal<int> (() => 3);

void Main()
{
	new Thread (() => { Thread.Sleep(1000); _x.Value++; _x.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(2000); _x.Value++; _x.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(3000); _x.Value++; _x.Dump(); }).Start();
}

