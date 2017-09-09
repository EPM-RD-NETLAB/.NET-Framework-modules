<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	new Foo().Expensive.Dump();
}

class Foo
{
	Lazy<Expensive> _expensive = new Lazy<Expensive> (() => new Expensive(), true);
	public Expensive Expensive { get { return _expensive.Value; } }
}

class Expensive {  /* Suppose this is expensive to construct */  }