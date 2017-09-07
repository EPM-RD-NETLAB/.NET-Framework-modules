<Query Kind="Program" />

void Main()
{
	foreach (int i in new MyIntList())
		Console.WriteLine (i);
}

public class MyIntList : IEnumerable
{
	int[] data = { 1, 2, 3 };

	public IEnumerator GetEnumerator() => new Enumerator (this);

	class Enumerator : IEnumerator       // Define an inner class
	{                                    // for the enumerator.
		MyIntList collection;
		int currentIndex = -1;

		internal Enumerator (MyIntList collection)
		{
			this.collection = collection;
		}

		public object Current
		{
			get
			{
				if (currentIndex == -1)
					throw new InvalidOperationException ("Enumeration not started!");
				if (currentIndex == collection.data.Length)
					throw new InvalidOperationException ("Past end of list!");
				return collection.data [currentIndex];
			}
		}

		public bool MoveNext()
		{
			if (currentIndex >= collection.data.Length - 1) return false;
			return ++currentIndex < collection.data.Length;
		}
		
		public void Reset() => currentIndex = -1;
	}
}