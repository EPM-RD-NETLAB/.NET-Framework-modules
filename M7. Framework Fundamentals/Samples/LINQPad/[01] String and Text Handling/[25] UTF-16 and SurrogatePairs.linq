<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

int musicalNote = 0x1D161;

string s = char.ConvertFromUtf32 (musicalNote);
s.Length.Dump();	// 2 (surrogate pair)

char.ConvertToUtf32 (s, 0).ToString ("X").Dump();			// Consumes two chars
char.ConvertToUtf32 (s[0], s[1]).ToString ("X").Dump();		// Explicitly specify two chars

