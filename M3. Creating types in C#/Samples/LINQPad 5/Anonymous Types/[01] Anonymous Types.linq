<Query Kind="Statements" />

// An anonymous type is a simple class created by the compiler on the fly to store a set of values

var dude = new { Name = "Bob", Age = 23 };
dude.Dump();

// The ToString() method is overloaded:
dude.ToString().Dump();