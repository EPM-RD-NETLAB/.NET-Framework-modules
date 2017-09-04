<Query Kind="Program" />

// The access modifiers are public, internal, protected and private.
//
// public is the default for members of an enum or interface.
// internal is the default for nonnested types.
// private is the default for everything else.

class Class1 {} 		// Class1 is internal (default) - visible to other types in same assembly
public class Class2 {}	// Class2 is visible to everything, including types in other assemblies

class ClassA
{
	int x;				// x is private (default) - cannot be accessed from other types
}

class ClassB
{
	internal int x;		// x can be accessed from other types in same assembly
}

class BaseClass
{
	void Foo()           {}    // Foo is private (default)
	protected void Bar() {}    // Foo is accessible to subclasses
}

class Subclass : BaseClass
{
   void Test1() { Foo(); }     // Error - cannot access Foo
   void Test2() { Bar(); }     // OK
}

static void Main() { }