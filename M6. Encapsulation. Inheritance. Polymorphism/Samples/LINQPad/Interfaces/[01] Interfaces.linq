<Query Kind="Program" />

// The IEnumerator interface is part of the .NET Framework, defined in System.Collections.
// We can define our own version of this as follows:

public interface IEnumerator
{
	bool MoveNext();
	object Current { get; }
	void Reset();
}

// Here's a class that implements this interface:

class Countdown : IEnumerator
{
	int count = 11;
	public bool MoveNext () { return count-- > 0 ;               }
	public object Current   { get { return count; }              }
	public void Reset()     { throw new NotSupportedException(); }
}

static void Main()
{
	IEnumerator e = new Countdown();
	while (e.MoveNext())
		Console.Write (e.Current);      // 109876543210	
}