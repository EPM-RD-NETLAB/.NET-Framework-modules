<Query Kind="Statements" />

string s1 = null;
string s2 = s1 ?? "nothing";   // s2 evaluates to "nothing"

s2.Dump();