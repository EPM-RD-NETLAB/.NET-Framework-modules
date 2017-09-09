<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	new Foo().Expensive.Dump();
}

class Foo
{
	Expensive _expensive;
	public Expensive Expensive         // Lazily instantiate Expensive
	{
		get
		{
			if (_expensive == null) _expensive = new Expensive();
			return _expensive;
		}
	}
}

class Expensive {  /* Suppose this is expensive to construct */  }