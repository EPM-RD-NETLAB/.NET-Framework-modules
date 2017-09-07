<Query Kind="Program" />

// As of C# 4.0, generic interfaces support covariance for type parameters marked with the out modifier:
public interface IPoppable<out T> { T Pop(); }

class Animal {}
class Bear : Animal {}
class Camel : Animal {}

public class Stack<T> : IPoppable<T>
{
	int position;
	T[] data = new T [100];
	public void Push (T obj) => data [position++] = obj;
	public T Pop()           => data [--position];
}

static void Main() 
{
	var bears = new Stack<Bear>();
	bears.Push (new Bear());
	
	// Bears implements IPoppable<Bear>. We can convert to IPoppable<Animal>:
	IPoppable<Animal> animals = bears;   		// Legal
	Animal a = animals.Pop();
}

// This is also now legal:
class ZooCleaner
{
	public static void Wash (IPoppable<Animal> animals) { /*...*/ }
}