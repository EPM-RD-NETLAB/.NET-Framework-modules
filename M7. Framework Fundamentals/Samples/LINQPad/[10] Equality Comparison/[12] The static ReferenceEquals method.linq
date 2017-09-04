<Query Kind="Program" />

class Widget
{
	// Let's suppose Widget overrides its Equals method and overloads its == operator such
	// that w1.Equals (w2) would return true if w1 and w2 were different objects.
	/*...*/
}

static void Main()
{
	Widget w1 = new Widget();
	Widget w2 = new Widget();
	Console.WriteLine (object.ReferenceEquals (w1, w2));     // False
}
