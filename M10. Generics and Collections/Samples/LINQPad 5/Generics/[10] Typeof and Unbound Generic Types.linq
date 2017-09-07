<Query Kind="Program" />

// It's possible for an unbound generic type to exist at runtime—purely as a Type object.

class A<T> {}
class A<T1,T2> {}

static void Main()
{
	// The only way to specify an unbound generic type in C# is with the typeof operator:
	Type a1 = typeof (A<>);   // Unbound type (notice no type arguments).
	Type a2 = typeof (A<,>);  // Use commas to indicate multiple type args.
	
	// You can also use the typeof operator to specify a closed type:
	Type a3 = typeof (A<int,int>);

}

// or an open type (which is closed at runtime):
class B<T> 
{
	void X() { Type t = typeof (T); }
}

