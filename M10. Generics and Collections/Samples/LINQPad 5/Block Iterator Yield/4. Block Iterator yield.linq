<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	var collection = new CustomContainer<string>(new[]
	{
		"one", "two", "three", "four"
	});

	foreach (var t in collection)
	{
		Debug.WriteLine(t);
	}
	Debug.WriteLine("");
	foreach (var t in collection.ReverseMethod())
	{
		Debug.WriteLine(t);
	}
	Debug.WriteLine("");
	foreach (var t in collection.ReverseProperty)
	{
		Debug.WriteLine(t);
	}

	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
		Assembly.GetExecutingAssembly().Location);

}

public class CustomContainer<T> //: IEnumerable<T>
{
	private readonly T[] container;

	public int Count { get { return container.Length; } }

	public T this[int index]
	{
		get { return container[index]; }
		set { container[index] = value; }
	}

	public CustomContainer(T[] array)
	{
		container = new T[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			container[i] = array[i];
		}
	}

	public IEnumerator<T> GetEnumerator()
	{
		for (var i = 0; i < container.Length; i++)
			yield return container[i];
		//return ((IEnumerable<T>) container).GetEnumerator();//as a variant
	}

	public IEnumerable<T> ReverseMethod()
	{
		for (var i = container.Length - 1; i >= 0; i--)
			yield return container[i];
	}

	public IEnumerable<T> ReverseProperty
	{
		get
		{
			for (var i = container.Length - 1; i >= 0; i--)
				yield return container[i];
		}
	}

	//IEnumerator IEnumerable.GetEnumerator()
	//{
	//            return GetEnumerator();
	//        }
}