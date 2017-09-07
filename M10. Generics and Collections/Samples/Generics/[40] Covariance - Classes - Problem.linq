<Query Kind="Program" />

// Generic classes are not covariant, to ensure static type safety. Consider the following:

class Animal {}
class Bear : Animal {}
class Camel : Animal {}

public class Stack<T>   // A simple Stack implementation
{
	int position;
	T[] data = new T[100];
	public void Push (T obj) => data[position++] = obj;
	public T Pop()           => data[--position];
}

static void Main() 
{
	// The following fails to compile:
	Stack<Bear> bears = new Stack<Bear>();
	Stack<Animal> animals = bears;			// Compile-time error
	
	// That restriction prevents the possibility of runtime failure with the following code:
	animals.Push (new Camel());      		// Trying to add Camel to bears
}