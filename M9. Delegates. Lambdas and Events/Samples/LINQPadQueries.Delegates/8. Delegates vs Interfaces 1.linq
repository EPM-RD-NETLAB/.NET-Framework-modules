<Query Kind="Program" />

delegate int TransformDelegate(int x);

static int Square (int x) { return x * x; }

static void TransformAll (int[] values, TransformDelegate t)
{
	for (int i = 0; i < values.Length; i++)
		values[i] = t(values[i]);
}

static void Main()
{
	int[] values = { 1, 2, 3 };
	TransformAll(values, Square);
	values.Dump();
}

