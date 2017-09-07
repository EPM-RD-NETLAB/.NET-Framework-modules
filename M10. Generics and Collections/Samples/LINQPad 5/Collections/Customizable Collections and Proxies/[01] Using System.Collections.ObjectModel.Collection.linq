<Query Kind="Program">
  
  <Namespace>System.Collections.ObjectModel</Namespace>
</Query>

public class Animal
{
	public string Name;
	public int Popularity;

	public Animal (string name, int popularity)
	{
		Name = name; Popularity = popularity;
	}
}

public class AnimalCollection : Collection <Animal>
{
	// AnimalCollection is already a fully functioning list of animals.
	// No extra code is required.
}

public class Zoo   // The class that will expose AnimalCollection.
{                  // This would typically have additional members.

	public readonly AnimalCollection Animals = new AnimalCollection();
}

static void Main()
{
	Zoo zoo = new Zoo();
	zoo.Animals.Add (new Animal ("Kangaroo", 10));
	zoo.Animals.Add (new Animal ("Mr Sea Lion", 20));
	foreach (Animal a in zoo.Animals) Console.WriteLine (a.Name);
}
