<Query Kind="Statements" />

// A string literal is specified inside double quotes:
string h = "Heat";

// string is a reference type, rather than a value type. Its equality operators, however, follow value-type semantics:
string a = "test";
string b = "test";
Console.WriteLine (a == b);  // True

// The escape sequences that are valid for char literals also work inside strings:
string t = "Here's a tab:\t";

// The cost of this is that whenever you need a literal backslash, you must write it twice:
string a1 = "\\\\server\\fileshare\\helloworld.cs";
a1.Dump ("a1");

// To avoid this problem, C# allows "verbatim string literals" - prefixed with @ symbols:
string a2 = @"\\server\fileshare\helloworld.cs";
a2.Dump ("a2");

// A verbatim string literal can also span multiple lines:
string escaped  = "First Line\r\nSecond Line";
string verbatim = @"First Line
Second Line";

// Assuming your IDE uses CR-LF line separators:
Console.WriteLine (escaped == verbatim);  // True

// You can include the double-quote character in a verbatim literal by writing it twice:
string xml = @"<customer id=""123""></customer>";
xml.Dump ("xml");