<Query Kind="Statements" />

// You can add the checked keyword to force overflow checking:

int a = 1000000;
int b = 1000000;

// The following code throws OverflowExceptions:

int c = checked (a * b);      // Checks just the expression.

// Checks all expressions in statement block:
checked
{                             
   int c2 = a * b;
   c2.Dump();
}