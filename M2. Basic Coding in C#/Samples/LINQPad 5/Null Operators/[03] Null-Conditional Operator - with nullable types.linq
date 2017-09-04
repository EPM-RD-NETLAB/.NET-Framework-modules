<Query Kind="Statements" />

System.Text.StringBuilder sb = null;
int? length = sb?.ToString().Length;   // OK : int? can be null

length.Dump();

string s = sb?.ToString() ?? "nothing";   // s evaluates to "nothing"
s.Dump();