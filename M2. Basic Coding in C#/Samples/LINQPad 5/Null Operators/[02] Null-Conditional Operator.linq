<Query Kind="Statements" />

System.Text.StringBuilder sb = null;
string s = sb?.ToString();	 // No error; s instead evaluates to null
s.Dump();

string s2 = sb?.ToString().ToUpper();   // s evaluates to null without error
s2.Dump();