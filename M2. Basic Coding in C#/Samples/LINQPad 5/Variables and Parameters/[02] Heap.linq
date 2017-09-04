<Query Kind="Statements" />

// The heap is a block of memory in which objects (i.e., reference-type instances) reside.
// The runtime has a garbage collector that periodically deallocates objects from the heap.

StringBuilder ref1 = new StringBuilder ("object1");
Console.WriteLine (ref1);
// The StringBuilder referenced by ref1 is now eligible for GC.

StringBuilder ref2 = new StringBuilder ("object2");
StringBuilder ref3 = ref2;
// The StringBuilder referenced by ref2 is NOT yet eligible for GC.

Console.WriteLine (ref3);                   // object2