<Query Kind="Program" />

// All delegate instances have multicast capability:

delegate void SomeDelegate();

static void Main()
{
	SomeDelegate d = SomeMethod1;
	d += SomeMethod2;

	d();	
	" -- SomeMethod1 and SomeMethod2 both fired\r\n".Dump();
	
	d -= SomeMethod1;
	d();
	" -- Only SomeMethod2 fired".Dump();
}

static void SomeMethod1 () { "SomeMethod1".Dump(); }
static void SomeMethod2 () { "SomeMethod2".Dump(); }