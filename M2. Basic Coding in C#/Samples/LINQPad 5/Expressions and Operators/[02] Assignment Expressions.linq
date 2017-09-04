<Query Kind="Statements" />

// An assignment expression is not a void expression. It actually carries the assignment
// value, and so can be incorporated into another expression:

int x, y;

y = 5 * (x = 2);

x.Dump();
y.Dump();

x *= 2;    // equivalent to x = x * 2
x <<= 1;   // equivalent to x = x << 1

x.Dump();