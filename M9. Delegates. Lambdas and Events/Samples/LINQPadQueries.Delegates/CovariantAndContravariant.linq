<Query Kind="Program" />

void Main()
{
	CovariantAndContravariandDelegate del = Do;
}

class Base {  }

class Derived : Base {  }

delegate Base CovariantAndContravariandDelegate(Derived derived);

Derived Do(Base obj)
{
	return new Derived();
}