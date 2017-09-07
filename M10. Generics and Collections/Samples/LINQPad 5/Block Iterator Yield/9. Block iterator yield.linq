<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	DateTime stop = DateTime.Now.AddSeconds(2);
    foreach (int i in CountWithTimeLimit(stop))
    {
        Console.WriteLine("Received {0}", i);
        Thread.Sleep(300);
    }

	Thread.Sleep(300);
	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
	Assembly.GetExecutingAssembly().Location);

}

static IEnumerable<int> CountWithTimeLimit(DateTime limit)
{
	for (int i = 1; i <= 100; i++)
	{
   		if (DateTime.Now >= limit)
   		{
    		yield break;//<- stop, time out
   		}
   		yield return i;
	}	
}