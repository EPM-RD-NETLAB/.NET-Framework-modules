<Query Kind="Program" />

// Lack of covariance with classes can hinder reusability. 

class Animal {}
class Bear : Animal {}
class Camel : Animal {}

public class Stack<T>   // A simple Stack implementation
{
	int position;
	T[] data = new T[100];
	public void Push (T obj) => data[position++] = obj;
	public T Pop()           => data [--position];
}

static class ZooCleaner
{
	public static void Wash (Stack<Animal> animals) { /*...*/ }
}

static void Main()
{
	Stack<Bear> bears = new Stack<Bear>();
	ZooCleaner.Wash (bears);				// Will not compile!
}