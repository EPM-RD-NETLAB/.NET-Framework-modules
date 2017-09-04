<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

public class Animal
{
	public virtual void Walk(int x) => Console.WriteLine("Animal.Walk");
}

public class Dog : Animal
{
	public override void Walk(int x) => Console.WriteLine("Dog.Walk");
}

public class Cat : Animal
{
	public override void Walk(int x) => Console.WriteLine("Cat.Walk.1");
	public void Walk(object x) => Console.WriteLine("Cat.Walk.2");
}

public static class CatExtention
{
	public static void Walk(this Cat c, int x) => Console.WriteLine("CatExt");
}

void Main()
{
	Cat cat1 = new Cat();
	cat1.Walk(12);
	Animal cat2 = cat1;
	cat2.Walk(12);
	dynamic cat3 = cat1;
	cat3.Walk(34);
}