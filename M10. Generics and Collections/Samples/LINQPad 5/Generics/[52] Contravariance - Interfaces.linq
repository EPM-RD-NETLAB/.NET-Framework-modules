<Query Kind="Program" />

// Type parameters marked with the in modifier indicate contravariance:
public interface IPoppable<out T> { T Pop(); }
public interface IPushable<in T> { void Push (T obj); }

class Animal {}
class Bear : Animal {}
class Camel : Animal {}

// Note that Stack<T> can implement both IPoppable<T> and IPushable<T>:
public class Stack<T> : IPoppable<T>, IPushable<T>
{
	int position;
	T[] data = new T[100];
	public void Push (T obj) => data[position++] = obj;
	public T Pop()           => data[--position];
}

static void Main() 
{
	IPushable<Animal> animals = new Stack<Animal>();
	IPushable<Bear> bears = animals;    // Legal
	bears.Push (new Bear());
}