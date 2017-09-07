<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	int[] arr = {1, 2, 3, 4, 5};

	ForEachIEnumerable(arr);
}

public static void ForEachIEnumerable(IEnumerable sequence)
{
	"foreach".Dump();
    foreach(var e in sequence) 
	{
		Console.WriteLine(e);
	}
	"foreach in depth".Dump();
    IEnumerator enumerator = sequence.GetEnumerator();
    object current = null;
    try
    {
        while (enumerator.MoveNext())
        {
            current = enumerator.Current;
            Console.WriteLine(current);
        }
    }
    finally
    {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
        {
            disposable.Dispose();
        }
    }
}