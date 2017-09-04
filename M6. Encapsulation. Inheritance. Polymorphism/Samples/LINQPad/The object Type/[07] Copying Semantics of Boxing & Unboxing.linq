<Query Kind="Statements" />

// Boxing copies the value-type instance into the new object, and unboxing copies
// the contents of the object back into a value-type instance.

int i = 3;
object boxed = i;
i = 5;
Console.WriteLine (boxed);    // 3
