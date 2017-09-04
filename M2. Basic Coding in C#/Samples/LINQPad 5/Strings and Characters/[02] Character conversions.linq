<Query Kind="Statements" />

// An implicit conversion from a char to a numeric type works for the numeric types that can
// accommodate an unsigned short:

ushort us = 'a';
int i = 'z';

us.Dump();
i.Dump();

// For other numeric types, an explicit conversion is required

short s = (short) 'a';
s.Dump();