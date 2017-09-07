<Query Kind="Program" />

// The default keyword can be used to get the default value given a generic type parameter:

static void Zap<T> (T[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = default(T);
}

static void Main()
{
	int[] numbers = { 1, 2, 3 };
	Zap (numbers);
	numbers.Dump();
}
