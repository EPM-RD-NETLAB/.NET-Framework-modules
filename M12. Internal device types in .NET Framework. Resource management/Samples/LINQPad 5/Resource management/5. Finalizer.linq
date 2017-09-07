<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	new GCBeep();
	
	for(int i = 0; i < 10; i++)
	{	
		var b = new int[100];
		Thread.Sleep(1000);
		GC.Collect();
	}
}

class GCBeep
{
	~GCBeep()
	{
		"Beep".Dump();
		new GCBeep();
	}
}