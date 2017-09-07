<Query Kind="Program">
  
</Query>

class Wish
{
	public string Name;
	public int Priority;

	public Wish (string name, int priority)
	{
		Name = name;
		Priority = priority;
	}
}

class PriorityComparer : Comparer <Wish>
{
	public override int Compare (Wish x, Wish y)
	{
		if (object.Equals (x, y)) return 0;          // Fail-safe check
		return x.Priority.CompareTo (y.Priority);
	}
}

void Main()
{
	var wishList = new List<Wish>();
	wishList.Add (new Wish ("Peace", 2));
	wishList.Add (new Wish ("Wealth", 3));
	wishList.Add (new Wish ("Love", 2));
	wishList.Add (new Wish ("3 more wishes", 1));
	
	wishList.Sort (new PriorityComparer());
	wishList.Dump();
}
