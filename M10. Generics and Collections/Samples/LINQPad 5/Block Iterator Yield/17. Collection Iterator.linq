<Query Kind="Program" />

void Main()
{
	List<int> a = new List<int> { 1, 2, 3, 4, 5 };
	var t = new { Item = a.GetEnumerator() };
	while(t.Item.MoveNext())
		Debug.WriteLine(t.Item.Current);
}
