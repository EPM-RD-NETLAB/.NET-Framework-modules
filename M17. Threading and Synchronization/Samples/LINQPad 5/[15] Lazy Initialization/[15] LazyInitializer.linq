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
	public Expensive Expensive
	{ 									 // Implement double-checked locking
		get 
		{ 
			LazyInitializer.EnsureInitialized (ref _expensive, () => new Expensive());
			return _expensive;
		}
	}
}

class Expensive {  /* Suppose this is expensive to construct */  }