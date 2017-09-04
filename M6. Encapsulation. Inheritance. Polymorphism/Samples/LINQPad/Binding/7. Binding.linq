<Query Kind="Program" />

void Main()
{

}

class B 
{
	public virtual void M(double x) { }
	
	public virtual void M(int x) { }
}

class C
{
	public static void X(object b, object[] d, string m, BindingFlags f)
	{
		b.GetType().GetMethod(m, f).Invoke(b, d);
	}
}