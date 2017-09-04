<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Base
{
	public virtual void Foo(int i) 
	{
		Console.WriteLine("Base.Foo(int)");
	}
}

class Derived : Base
{
	public override void Foo(int i) 
	{
		Console.WriteLine("Derived.Foo(int)");
	}

	public void Foo(object o)
	{
		Console.WriteLine("Derived.Foo(object)");
	}
}

void Main()
{
	int i = 42;
	Derived d = new Derived();
	d.Foo(i);
	Base b = d;
	b.Foo(i);
}

#region Advanced

//Cпецификация: компилятор трактует объявление и переопределение метода 
//по разному, он вначале ищет подходящий метод в классе текущей переменной 
//(т.е. в классе Derived) и если подходящая перегрузка будет найдена
//(даже если понадобится неявное приведение типов), то он на этом и
//успокоится и рассматривать базовые классы (т.е. класс Base) не будет, 
//даже если там есть более подходящая версия метода, 
//переопределяемая наследником

#endregion