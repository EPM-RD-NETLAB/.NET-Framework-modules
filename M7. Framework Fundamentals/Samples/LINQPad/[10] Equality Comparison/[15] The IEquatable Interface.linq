<Query Kind="Program" />

class Test<T> where T : IEquatable<T>
{
	public bool IsEqual (T a, T b) =>  a.Equals (b);     // No boxing with generic T
}

static void Main()
{
	new Test<int>().IsEqual (3, 3).Dump();
}