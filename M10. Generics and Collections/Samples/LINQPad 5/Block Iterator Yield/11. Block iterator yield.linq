<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//в обычных методах оператор return имеет два эффекта
//представляет значение, которое вызывающая сторона видит, как возвращаемое 
//обеспечивает выполнение любых соответсвующих блоков   finally на выходе

void Main()
{
	DateTime stop = DateTime.Now.AddSeconds(2);
    foreach (int i in CountWithTimeLimit(stop))
    {
        Console.WriteLine("Received {0}", i);
        Thread.Sleep(300);
    }
	
   	Thread.Sleep(300);
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
	Assembly.GetExecutingAssembly().Location);

}

static IEnumerable<int> CountWithTimeLimit(DateTime limit)
{
	try
	{
		for (int i = 1; i <= 10; i++)
		{
			//Здесь производится ранний останов в коде итератора
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