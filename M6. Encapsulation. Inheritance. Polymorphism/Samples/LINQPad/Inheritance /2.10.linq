<Query Kind="Program" />

void Main()
{
	Base b = new Base();
	b = new DerivedAgain();
	b.Turn();
	"".Dump();
	DerivedAgain d = new DerivedAgain();
	d.Turn();
}

public interface IVerticle
{
	void Start();
	void Stop();
	void Turn();
}

public class Base : IVerticle
{
	void IVerticle.Start()
	{
		"IVerticle.Start".Dump();
	}

	public void Stop()
	{
		"Stop(Iverticle)".Dump();
	}

	public virtual void Turn()
	{
		"Base Turn(Iverticle)".Dump();
	}
}

public class Derived : Base
{
//	public override void Start()
//	{
//		"Start".Dump();
//	}

//	public override void Stop()
//	{
//		"Stop(Iverticle)".Dump();
//	}

	public override void Turn()
	{
		"override Turn(Iverticle)".Dump();
	}
}

public class DerivedAgain : Base, IVerticle
{
	void IVerticle.Start()
	{
		"Start".Dump();
	}

	public new void Stop()
	{
		"Stop(Iverticle)".Dump();
	}

	public new void Turn()
	{
		"DerivedAgain Turn(Iverticle)".Dump();
	}
}