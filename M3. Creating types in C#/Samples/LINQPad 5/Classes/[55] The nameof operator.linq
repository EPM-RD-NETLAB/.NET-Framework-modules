<Query Kind="Statements" />

int count = 123;
nameof (count).Dump ("count");

nameof (StringBuilder.Length).Dump ("Length property on StringBuilder");

(nameof (StringBuilder) + "." + nameof (StringBuilder.Length)).Dump ("StringBuilder.Length");

