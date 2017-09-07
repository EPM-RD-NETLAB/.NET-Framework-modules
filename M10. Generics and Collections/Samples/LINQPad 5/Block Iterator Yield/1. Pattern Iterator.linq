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

    CustomContainer<string>.CustomIterator iterator = collection.Iterator();
	
    while (iterator.MoveNext())
    {
        Debug.WriteLine(iterator.Current);
    }
    iterator.Reset();
	while (iterator.MoveNext())
    {
        Debug.WriteLine(iterator.Current);
    }
	var collectionInt = new CustomContainer<int>(new[]
    {
        1, 2, 3, 4
    });

    CustomContainer<int>.CustomIterator iterator1 = collectionInt.Iterator();

    while (iterator1.MoveNext())
    {
        Debug.WriteLine(iterator1.Current);
    }
    iterator1.Reset();
}

	public class CustomContainer<T>
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

		public CustomIterator Iterator()
        {
            return new CustomIterator(this);
        } 

        public struct CustomIterator
        {
            private readonly CustomContainer<T> collection;
            private int currentIndex;

            internal CustomIterator(CustomContainer<T> collection)
            {
                this.currentIndex = -1;
                this.collection = collection;
            }

            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == collection.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return collection[currentIndex];
                }
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                return ++currentIndex < collection.Count;
            }

            // InvalidOperationException - при изменении коллекции!
        }       
    }