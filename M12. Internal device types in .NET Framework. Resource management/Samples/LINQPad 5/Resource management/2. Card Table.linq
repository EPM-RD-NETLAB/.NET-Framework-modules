<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	var a = new A();
	GC.Collect();
	GC.Collect();
 	Debug.WriteLine("Generation of a is: {0}", GC.GetGeneration(a));
	// output: A resides in Gen 2, A.B resides in Gen 0
	Debug.WriteLine("A resides in Gen {0}, A.B resides in Gen {1}",
		GC.GetGeneration(a), GC.GetGeneration(a.B));

	GC.Collect();
	Debug.WriteLine("A resides in Gen {0}, A.B resides in Gen {1}",
		GC.GetGeneration(a), GC.GetGeneration(a.B));
	a.B.Dump();
}
public class B
{ }

public class A
{
	private Lazy<B> _lazyB = new Lazy<B>(() => new B());

	public B B
    {
        get { return _lazyB.Value; }
    }
}