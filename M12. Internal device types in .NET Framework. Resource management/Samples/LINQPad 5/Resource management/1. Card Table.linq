<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

public static void Main() 
{
	Timer t = new Timer(TimerCallback,null,0,1000);
  	Thread.Sleep(3000);
	//t = null;
	//t.Dispose();
	//GC.KeepAlive(t);
	//using (var timer = new Timer(TimerCallback,null,0,200))
	//{
	//	Thread.Sleep(3000);
	//}
}

private static void TimerCallback(Object o) 
{
    Console.WriteLine("In TimerCallback: " + DateTime.Now);
    GC.Collect();
}