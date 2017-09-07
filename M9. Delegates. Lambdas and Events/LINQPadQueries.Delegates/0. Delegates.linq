<Query Kind="Program" />

static int Square (int x) { return x * x; }
static int Cube (int x) { return x * x * x; }

static void TransformValue(int value)
{
	Square(value).Dump();
}

static void TransformAll (int[] values)
{
	for (int i = 0; i < values.Length; i++)
		values[i] = Square(values[i]);
}

static void Main()
{
	int result = Square(3);             
	result.Dump();    
	TransformValue(result);
	var array = new int[]{1, 2, 3};
	TransformAll(array);
	array.Dump();
}