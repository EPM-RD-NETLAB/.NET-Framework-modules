<Query Kind="Program" />

public sealed class SimpleType : IDisposable 
{
	public void Dispose() { Console.WriteLine("Dispose (no interface)"); }
	void IDisposable.Dispose() { Console.WriteLine("Dispose (IDisposable) - Explicit Interface Method Implementation (EIME)"); }
}


void Main()
{
	SimpleType st = new SimpleType();
	st.Dispose();
	IDisposable d = st;
	d.Dispose();	
}