<Query Kind="Program" />

// A generic class can be subclassed just like a nongeneric class.
// The subclass can leave the base class’s type parameters open:

class Stack<T>                   { /*...*/ }
class SpecialStack<T> : Stack<T> { /*...*/ }

// Or the subclass can close the generic type parameters with a concrete type:

class IntStack : Stack<int>  { /*...*/ }

// A subtype can also introduce fresh type arguments:

class List<T>                     { /*...*/ }
class KeyedList<T,TKey> : List<T> { /*...*/ }

static void Main() { }