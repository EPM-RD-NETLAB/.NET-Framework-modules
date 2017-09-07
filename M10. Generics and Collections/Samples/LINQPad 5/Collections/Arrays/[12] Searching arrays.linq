<Query Kind="Statements">
  
</Query>

string[] names = { "Rodney", "Jack", "Jill", "Jane" };

Array.Find    (names, n => n.Contains ("a")).Dump();	// Returns first matching element
Array.FindAll (names, n => n.Contains ("a")).Dump();	// Returns all matching elements

// Equivalent in LINQ:

names.FirstOrDefault (n => n.Contains ("a")).Dump();
names.Where          (n => n.Contains ("a")).Dump();
