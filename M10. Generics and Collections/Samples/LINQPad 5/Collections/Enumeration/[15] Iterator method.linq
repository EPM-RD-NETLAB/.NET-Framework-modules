<Query Kind="Program">
  
</Query>

void Main()
{
	foreach (int i in Test.GetSomeIntegers())
		Console.WriteLine (i);
}

public class Test
{
	public static IEnumerable <int> GetSomeIntegers()
	{
		yield return 1;
		yield return 2;
		yield return 3;
	}
}
