<Query Kind="Statements" />

// The && and || operators short-circuit. This is essential in allowing expressions such as
// the following to run without throwing a NullReferenceException:

StringBuilder sb = null;

if (sb != null && sb.Length > 0) 
	Console.WriteLine ("sb has data");
else
	Console.WriteLine ("sb is null or empty");

