<Query Kind="Statements" />

// You can mix and match nullable and non-nullable types
// (this works because there is an implicit conversion from T to T?):

int? a = null;
int b = 2;
int? c = a + b;   // c is null - equivalent to a + (int?)b

c.Dump();
