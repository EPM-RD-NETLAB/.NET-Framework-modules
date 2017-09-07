<Query Kind="Program" />

// Type parameters can be introduced in the declaration of classes, structs, interfaces,
// delegates (covered in Chapter 4), and methods:
struct Nullable<T>
{
	public T Value { get; set; }
}

// A generic type or method can have multiple parameters:
class Dictionary <TKey, TValue> { /*...*/ }

static void Main()
{
	// To instantiate:
	Dictionary<int,string> myDic = new Dictionary<int,string>();
	
	// Or:
	var myDicEasy = new Dictionary<int,string>();
}

// Generic type names and method names can be overloaded as long as the number of type parameters is different:
class A        { }
class A<T>     { }
class A<T1,T2> { }