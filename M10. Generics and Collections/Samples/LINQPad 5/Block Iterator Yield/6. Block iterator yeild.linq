<Query Kind="Program" />

public static IEnumerator<int> GetNumbers()
{
	Console.WriteLine("First string GetNumbers() method"); // 1
	Console.WriteLine("Before yield return 7"); // 2
	yield return 7;  // 3
	Console.WriteLine("After yield return 7"); // 4
	Console.WriteLine("Before yield return 42"); // 5 
	yield return 42;  // 6
	Console.WriteLine("After yield return 42");  //7
}

void Main()
{
	Console.WriteLine("Call GetNumbers()");
	IEnumerator<int> iterator = GetNumbers();
	Console.WriteLine("Call MoveNext()...");
	bool more = iterator.MoveNext();
	Console.WriteLine("Result={0}; Current={1}", more, iterator.Current);
	Console.WriteLine("Call MoveNext()...");
	more = iterator.MoveNext();
	Console.WriteLine("Result={0}; Current={1}", more, iterator.Current);
	Console.WriteLine("Call MoveNext()...");
	more = iterator.MoveNext();
	Console.WriteLine("Result={0} (stopping)", more);
//	foreach(var t in GetNumbers())
//		t.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}