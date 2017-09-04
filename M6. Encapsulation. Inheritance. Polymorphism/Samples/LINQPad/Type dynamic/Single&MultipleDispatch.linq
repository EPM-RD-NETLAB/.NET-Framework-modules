<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Animal
{
	public virtual void Walk(){"Animal.Walk.Virt".Dump();}
}

class Dog : Animal
{
	public override void Walk(){"Dog.Walk.Virt.Over".Dump();}
}

class Cat : Animal
{
	public override void Walk(){"Cat.Walk.Virt.Over".Dump();}
	public void Walk(int x){"Cat.Walk".Dump();}
}

void Main()
{
	dynamic cat = new Cat();
	cat.Walk();
	
	Animal o = new Cat();
	o.Walk();
}