<Query Kind="Program" />

static void Main()
{
	// Simple value equality:
	int x = 5, y = 5;
	Console.WriteLine (x == y);   // True (by virtue of value equality)
	
	// A more elaborate demonstration of value equality:
	var dt1 = new DateTimeOffset (2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
	var dt2 = new DateTimeOffset (2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));
	Console.WriteLine (dt1 == dt2);   // True (same point in time)

	// Referential equality:
	Foo f1 = new Foo { X = 5 };
	Foo f2 = new Foo { X = 5 };
	Console.WriteLine (f1 == f2);   // False (different objects)
	
	Foo f3 = f1;
	Console.WriteLine (f1 == f3);   // True (same objects)
	
	// Customizing classes to exhibit value equality:
	Uri uri1 = new Uri ("http://www.linqpad.net");
	Uri uri2 = new Uri ("http://www.linqpad.net");
	Console.WriteLine (uri1 == uri2);              // True
}

class Foo { public int X; }