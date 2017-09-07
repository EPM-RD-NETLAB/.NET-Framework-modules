<Query Kind="Program" />

// A generic type declares type parameters—placeholder types to be filled in by the consumer
// of the generic type, which supplies the type arguments:

public class Stack<T>
{
  int position;
  T[] data = new T[100];
  public void Push (T obj) => data[position++] = obj;
  public T Pop()           => data[--position];
}

static void Main()
{
	var stack = new Stack<int>();
	stack.Push(5);
	stack.Push(10);
	int x = stack.Pop();        // x is 10
	int y = stack.Pop();        // y is 5
	
	x.Dump(); y.Dump();
}