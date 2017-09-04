<Query Kind="Statements" />

// The + operator concatenates two strings:
string s1 = "a" + "b";
s1.Dump();

// The righthand operand may be a nonstring value, in which case ToString is called on that value:
string s2 = "a" + 5;   // a5
s2.Dump();