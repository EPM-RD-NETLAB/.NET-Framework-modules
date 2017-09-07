<Query Kind="Program" />

class Animal {}
class Bear : Animal {}
class Camel : Animal {}

static void Main() 
{
	// For historical reasons, array types are covariant.
	Bear[] bears = new Bear[3];
	Animal[] animals = bears;     // OK

	// The downside of this reusability is that element assignments can fail at runtime:
	animals[0] = new Camel();     // Runtime error
}
