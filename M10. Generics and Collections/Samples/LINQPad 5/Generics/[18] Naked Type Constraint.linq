<Query Kind="Program" />

// The naked type constraint requires one type parameter to derive from another type parameter:

class Stack<T>
{
	Stack<U> FilteredStack<U>() where U : T
	{
		/* ... */
		return default(Stack<U>);
	}
}

static void Main() { }
