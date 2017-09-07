<Query Kind="Program" />

public static class CustomSequenceOperators
{ 
	public static IEnumerable<T> Combine<T>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, T> func) 
	{ 
		using (IEnumerator<T> e1 = first.GetEnumerator(), e2 = second.GetEnumerator()) 
		{ 
			while (e1.MoveNext() && e2.MoveNext()) 
				yield return func(e1.Current, e2.Current); 
		} 
	} 
} 

void Main()
{
    int[] vectorA = { 0, 2, 4, 5, 6 }; 
	int[] vectorB = { 1, 3, 5, 7, 8 }; 
	vectorA.Combine(vectorB, (a, b) => a * b).Sum().Dump("Dot product: ");
}
