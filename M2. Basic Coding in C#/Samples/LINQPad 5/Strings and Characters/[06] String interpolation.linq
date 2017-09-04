<Query Kind="Statements" />

// A string preceded with the $ character is an interpolated string:

int x = 4;
Console.WriteLine ($"A square has {x} sides");    // Prints: A square has 4 sides

string s = $"255 in hex is {byte.MaxValue:X2}";   // X2 = 2-digit Hexadecimal
s.Dump ("With a format string");

x = 2;
s = $@"this spans {
x} lines";

s.Dump ("Verbatim multi-line interpolated string");
