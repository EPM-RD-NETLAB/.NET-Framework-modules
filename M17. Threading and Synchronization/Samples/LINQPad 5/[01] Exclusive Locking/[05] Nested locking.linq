<Query Kind="Program" />

static readonly object _locker = new object();

static void Main()
{
  lock (_locker)
  {
	 AnotherMethod();
	 // We still have the lock - because locks are reentrant.
  }
}

static void AnotherMethod()
{
  lock (_locker) { Console.WriteLine ("Another method"); }
}
