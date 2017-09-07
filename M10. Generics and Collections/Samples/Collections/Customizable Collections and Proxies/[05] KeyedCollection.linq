<Query Kind="Program">
  
  <Namespace>System.Collections.ObjectModel</Namespace>
</Query>

public class Animal
{
	string name;
	public string Name
	{
		get { return name; }
		set {
			if (Zoo != null) Zoo.Animals.NotifyNameChange (this, value);
			name = value;
		}
	}
	public int Popularity;
	public Zoo Zoo { get; internal set; }

	public Animal (string name, int popularity)
	{
		Name = name; Popularity = popularity;
	}
}

public class AnimalCollection : KeyedCollection <string, Animal>
{
	Zoo zoo;
	public AnimalCollection (Zoo zoo) { this.zoo = zoo; }

	internal void NotifyNameChange (Animal a, string newName)
	{
		this.ChangeItemKey (a, newName);
	}

	protected override string GetKeyForItem (Animal item)
	{
		return item.Name;
	}

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
	Console.WriteLine (zoo.Animals [0].Popularity);               // 10
	Console.WriteLine (zoo.Animals ["Mr Sea Lion"].Popularity);   // 20
	zoo.Animals ["Kangaroo"].Name = "Mr Roo";
	Console.WriteLine (zoo.Animals ["Mr Roo"].Popularity);        // 10
}
