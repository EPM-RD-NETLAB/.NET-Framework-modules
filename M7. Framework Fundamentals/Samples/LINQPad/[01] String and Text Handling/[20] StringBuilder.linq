<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// Unlike string, StringBuilder is mutable.

// The following is more efficient than repeatedly concatenating ordinary string types:

StringBuilder sb = new StringBuilder();

for (int i = 0; i < 50; i++) sb.Append (i + ",");

// To get the final result, call ToString():
Console.WriteLine (sb.ToString());

sb.Remove (0, 60);		// Remove first 50 characters
sb.Length = 10;			// Truncate to 10 characters
sb.Replace (",", "+");	// Replace comma with +
sb.ToString().Dump();

sb.Length = 0;			// Clear StringBuilder