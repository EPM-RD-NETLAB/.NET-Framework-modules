<Query Kind="Program" />

// The following overloads are prohibited:

void  Foo (int x);
float Foo (int x);           // Compile-time error

void  Goo (int[] x);
void  Goo (params int[] x);  // Compile-time error

void Hoo (int x);
void Hoo (ref int x);      // OK so far
void Hoo (out int x);      // Compile-time error