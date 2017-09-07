<Query Kind="Statements">
  
</Query>

// Via C#'s native syntax:

int[] myArray = { 1, 2, 3 };
int first = myArray [0];
int last = myArray [myArray.Length - 1];

// Using GetValue/SetValue:

// Create a string array 2 elements in length:
Array a = Array.CreateInstance (typeof(string), 2);
a.SetValue ("hi", 0);                             //  → a[0] = "hi";
a.SetValue ("there", 1);                          //  → a[1] = "there";
a.Dump();
string s = (string) a.GetValue (0);               //  → s = a[0];
s.Dump();

// We can also cast to a C# array as follows:
string[] cSharpArray = (string[]) a;
string s2 = cSharpArray [0];
s2.Dump();