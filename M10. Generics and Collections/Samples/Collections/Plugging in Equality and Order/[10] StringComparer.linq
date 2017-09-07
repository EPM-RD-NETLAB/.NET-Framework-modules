<Query Kind="Statements">
  
  <Namespace>System.Globalization</Namespace>
</Query>

var dict = new Dictionary<string, int> (StringComparer.OrdinalIgnoreCase);
dict["joe"] = 12345;
dict["JOE"].Dump();

string[] names = { "Tom", "HARRY", "sheila" };
CultureInfo ci = new CultureInfo ("en-AU");
Array.Sort<string> (names, StringComparer.Create (ci, false));
names.Dump();