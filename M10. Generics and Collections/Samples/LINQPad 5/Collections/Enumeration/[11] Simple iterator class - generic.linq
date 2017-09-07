<Query Kind="Program">
  
</Query>

void Main()
{
	foreach (int element in new MyGenCollection())
		Console.WriteLine (element);
}

public class MyGenCollection : IEnumerable<int>
{
	int[] data = { 1, 2, 3 };

	public IEnumerator<int> GetEnumerator()
	{
		foreach (int i in data)
			yield return i;
	}

	IEnumerator IEnumerable.GetEnumerator()     // Explicit implementation
	{                                           // keeps it hidden.
		return GetEnumerator();
	}
}
