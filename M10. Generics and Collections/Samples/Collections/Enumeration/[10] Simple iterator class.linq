<Query Kind="Program">
  
</Query>

void Main()
{
	foreach (int element in new MyCollection())
		Console.WriteLine (element);
}

public class MyCollection : IEnumerable
{
	int[] data = { 1, 2, 3 };
	
	public IEnumerator GetEnumerator()
	{
		foreach (int i in data)
			yield return i;
	}
}