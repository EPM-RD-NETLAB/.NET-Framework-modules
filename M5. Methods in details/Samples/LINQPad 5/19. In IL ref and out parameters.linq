<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	int x = 24, y = 56;
	ChangeIt(out x, ref y);
	Console.WriteLine(x); // will print 42
	Console.WriteLine(y); // will print 42
	System.Diagnostics.Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

static void ChangeIt(out int a, ref int b) 
{
	a = 42; 
	b = 42;
}