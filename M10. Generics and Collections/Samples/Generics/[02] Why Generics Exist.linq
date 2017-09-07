<Query Kind="Program" />

// Generics exist to write code that is reusable across different types. Without generic types,
// writing a general-purpose stack would require a solution such as this:

public class ObjectStack
{
	int position;
	object[] data = new object[10];
	public void Push (object obj) => data[position++] = obj;
	public object Pop()           => data[--position];
}

static void Main()
{
	// Now suppose we want a stack that stores just integers:
	ObjectStack stack = new ObjectStack();
	
	// It's easy to make mistakes:
	stack.Push ("s");          // Wrong type, but no error!
	int i = (int)stack.Pop();  // Downcast - runtime error!
}