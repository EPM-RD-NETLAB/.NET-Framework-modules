<Query Kind="Program" />

// object (System.Object) is the ultimate base class for all types. Any type can be
// implicitly converted to object; we can leverage this to write a general-purpose Stack:

public class Stack
{
	int position;
	object[] data = new object[10];
	public void Push (object obj)   { data[position++] = obj;  }
	public object Pop()             { return data[--position]; }
}

// Because Stack works with the object type, we can Push and Pop instances of any type to and from the Stack:

static void Main()
{
	Stack stack = new Stack();
	stack.Push ("sausage");
	string s = (string) stack.Pop();   // Downcast, so explicit cast is needed
	Console.WriteLine (s);             // sausage
	
	// You can even push value types:
	stack.Push (3);
	int three = (int) stack.Pop();
}