<Query Kind="Program" />

void Main()
{
	var r1 = new ReallyDerived();
	ICommon i1 = r1;
	
	r1.DoIt();
	i1.DoIt();
	
	Derived r2 = r1;
	r2.DoIt();
	
	Base r3 = r1;
	r3.DoIt();
	
	ICommon r4 = r1;
	r4.DoIt();
//	Process.Start (@"C:\Users\MIB\Desktop\ildasm.exe",Assembly.GetExecutingAssembly().Location);
}

interface ICommon
{
	void DoIt();
}

class Base : ICommon
{
	void ICommon.DoIt(){ "implicit interface ICommon implementation method DoIt in Base class ".Dump(); }
	public virtual void DoIt() {"not a inerface impementation method DoIt of Base class".Dump(); }
}

class Derived : Base, ICommon
{
	void ICommon.DoIt(){ "implicit interface ICommon implementation method DoIt in Derived class".Dump(); }
	public new virtual void DoIt() {"new polymorphic chain replacement, hide method DoIt of Base class".Dump(); }
}

class ReallyDerived : Derived
{
	public override void DoIt() {"override vitrual method DoIt of ReallyDerived class".Dump(); }
}