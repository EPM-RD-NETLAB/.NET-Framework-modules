<Query Kind="Program" />

void Main()
{

}

class B
{
	public void M(double x) { }
	
	public void M(int x) { }
}
class C
{
	public static void X(B b, int d)
	{
		b.M(d);
	}
}