<Query Kind="Program">
  <Namespace>System.Collections.ObjectModel</Namespace>
</Query>

public class Animal
{
	public string Name;
	public int Popularity;
	
	public Zoo Zoo { get; internal set; }

	public Animal (string name, int popularity)
	{
		Name = name; Popularity = popularity;
	}
}

public class AnimalCollection : Collection <Animal>
{
	Zoo zoo;
	public AnimalCollection (Zoo zoo) { this.zoo = zoo; }

	protected override void InsertItem (int index, Animal item)
	{
		base.InsertItem (index, item);
		item.Zoo = zoo;
	}
	protected override void SetItem (int index, Animal item)
	{
		base.SetItem (index, item);
		item.Zoo = zoo;
	}
	protected override void RemoveItem (int index)
	{
		this [index].Zoo = null;
		base.RemoveItem (index);
	}
	protected override void ClearItems()
	{
		foreach (Animal a in this) a.Zoo = null;
		base.ClearItems();
	}
}

public class Zoo
{
	public readonly AnimalCollection Animals;
	public Zoo() { Animals = new AnimalCollection (this); }
}

static void Main()
{
	Zoo zoo = new Zoo();
	zoo.Animals.Add (new Animal ("Kangaroo", 10));
	zoo.Animals.Add (new Animal ("Mr Sea Lion", 20));
	foreach (Animal a in zoo.Animals) Console.WriteLine (a.Name);
}