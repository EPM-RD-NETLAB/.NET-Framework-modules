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
		Console.WriteLine ("Received {0}", i);
		//Здесь производится не ранний останов в коде итератора,
		//а ранний останов в коде, использующем этот итератор
   		if (i > 3)
   		{
      		Console.WriteLine("Returning");
			return;
		}
	}
}

static IEnumerable<int> CountWithTimeLimit(DateTime limit)
{
	try
	{
		for (int i = 1; i <= 100; i++)
		{
   			if (DateTime.Now >= limit)
   			{
      			yield break;
   			}
   			yield return i;
		}
	}
	finally
	{
		"Stopping!".Dump();
	}
}