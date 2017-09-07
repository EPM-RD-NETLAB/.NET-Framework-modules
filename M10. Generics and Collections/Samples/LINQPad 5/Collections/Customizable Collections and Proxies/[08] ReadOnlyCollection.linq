<Query Kind="Program">
  
  <Namespace>System.Collections.ObjectModel</Namespace>
</Query>

public class Test
{
	List<string> names;
	public ReadOnlyCollection<string> Names { get; private set; }

	public Test()
	{
		names = new List<string>();
		Names = new ReadOnlyCollection<string> (names);
	}

	public void AddInternally() { names.Add ("test"); }
}

void Main()
{
	Test t = new Test();

	Console.WriteLine (t.Names.Count);       // 0
	t.AddInternally();
	Console.WriteLine (t.Names.Count);       // 1
	
	t.Names.Add ("test");                    // Compiler error
	((IList<string>) t.Names).Add ("test");  // NotSupportedException
}