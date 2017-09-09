<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

[ThreadStatic] static int _x;

void Main()
{
	new Thread (() => { Thread.Sleep(1000); _x++; _x.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(2000); _x++; _x.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(3000); _x++; _x.Dump(); }).Start();
}

