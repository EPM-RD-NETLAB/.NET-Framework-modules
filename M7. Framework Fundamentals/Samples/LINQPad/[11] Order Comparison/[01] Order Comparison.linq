<Query Kind="Statements" />

// The static Array.Sort method works because System.String implements the IComparable interfaces:

string[] colors = { "Green", "Red", "Blue" };
Array.Sort (colors);
foreach (string c in colors) Console.Write (c + " ");   // Blue Green Red
