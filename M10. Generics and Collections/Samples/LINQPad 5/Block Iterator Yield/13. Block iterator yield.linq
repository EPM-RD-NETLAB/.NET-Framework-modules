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
	IEnumerable<int> iterable = CountWithTimeLimit(stop); 
	IEnumerator<int> iterator = iterable.GetEnumerator();
	iterator.MoveNext();
	Console.WriteLine("Received {0}", iterator.Current);
	iterator.MoveNext();
	Console.WriteLine("Received {0}", iterator.Current);
	//iterator.Dispose();
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