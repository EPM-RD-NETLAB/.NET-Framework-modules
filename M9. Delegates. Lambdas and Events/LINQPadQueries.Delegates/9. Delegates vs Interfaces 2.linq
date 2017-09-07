<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

// Помимо обеспечения полиморфизма между различными иерархиями классов,
// интерфейсы можно применять для поддержки механизма обратного вызова 
//(callback) — передача исполняемого кода в качестве одного из параметров
//другого кода

delegate int TransformDelegate(int x);

static int Square(int x) { return x * x; }

static void TransformAll(int[] values, TransformDelegate t)
{
	for (int i = 0; i < values.Length; i++)
		values[i] = t(values[i]);
}

public interface ITransformer
{
	int Transform(int x);
}

class Squarer : ITransformer
{
	public int Transform(int x) { return x * x; }
}

static void TransformAll(int[] values, ITransformer t)
{
	for (int i = 0; i < values.Length; i++)
		values[i] = t.Transform(values[i]);//  <<---
}

public static void Main()
{
	int[] values = { 1, 2, 3 };
	TransformAll(values, new Squarer());
	TransformAll(values, new TransformDelegate(Square));
//	var d = new TransformDelegate(Square);
//	TransformAll(values, new Squarer().Transform);
//	TransformAll(values, new Adapter(d));
//	values.Dump();
}

class Adapter : ITransformer
{
	TransformDelegate del;
	
	public Adapter(TransformDelegate del)
	{
		this.del = del;
	}

	public int Transform(int x)
	{
		return del(x);
	}
}


//решение на основе делегата может быть долее удачным, 
//чем на основе интерфейса, если
//соблюдено одно или несколько условий:
//интерфейс определяет только один метод
//требуется возможность группового вызова
//подписчик должен реализовать интерфейс несколько раз