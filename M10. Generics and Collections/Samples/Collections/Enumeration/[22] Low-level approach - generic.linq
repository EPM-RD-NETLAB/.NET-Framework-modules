<Query Kind="Program" />

void Main()
{
	foreach (int i in new MyIntList())
		Console.WriteLine (i);
}

class MyIntList : IEnumerable<int>
{
	int[] data = { 1, 2, 3 };

	// The generic enumerator is compatible with both IEnumerable and
	// IEnumerable<T>. We implement the nongeneric GetEnumerator method
	// explicitly to avoid a naming conflict.

	public IEnumerator<int> GetEnumerator() => new Enumerator(this);
	IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

	class Enumerator : IEnumerator<int>
	{
		int currentIndex = -1;
		MyIntList collection;

		internal Enumerator (MyIntList collection)
		{
			this.collection = collection;
		}

		public int Current { get { return collection.data [currentIndex]; } }
		object IEnumerator.Current { get { return Current; } }

		public bool MoveNext() => ++currentIndex < collection.data.Length;

		public void Reset() => currentIndex = -1;

		// Given we don't need a Dispose method, it's good practice to
		// implement it explicitly, so it's hidden from the public interface.

		void IDisposable.Dispose() {}
	}
}