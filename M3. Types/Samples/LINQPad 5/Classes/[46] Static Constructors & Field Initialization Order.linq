<Query Kind="Program" />

// Static field initializers run just before the static constructor is called:

class Foo
{
  public static int X = Y;    // 0
  public static int Y = 3;    // 3
}

static void Main()
{
	Foo.X.Dump ("X");	// 0
	Foo.Y.Dump ("Y");	// 3
}
