<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// Culture-agnostic:
string s = DateTime.Now.ToString ("o");

// ParseExact demands strict compliance with the specified format string:
DateTime dt1 = DateTime.ParseExact (s, "o", null);

// Parse implicitly accepts both the "o" format and the CurrentCulture format:
DateTime dt2 = DateTime.Parse (s);

dt1.Dump(); dt2.Dump();