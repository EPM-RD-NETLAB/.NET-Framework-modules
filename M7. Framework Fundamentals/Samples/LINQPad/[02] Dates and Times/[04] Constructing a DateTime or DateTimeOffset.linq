<Query Kind="Statements" />

DateTime d1 = new DateTime (2010, 1, 30);	// Midnight, January 30 2010
d1.Dump ("d1");

DateTime d2 = new DateTime (2010, 1, 30, 12, 0, 0);		// Midday, January 30 2010
d2.Dump ("d2");
d2.Kind.Dump();

DateTime d3 = new DateTime (2010, 1, 30, 12, 0, 0, DateTimeKind.Utc);
d3.Dump ("d3");
d3.Kind.Dump();

DateTimeOffset d4 = d1;		// Implicit conversion
d4.Dump ("d4");

DateTimeOffset d5 = new DateTimeOffset (d1, TimeSpan.FromHours (-8));	// -8 hours UTC
d5.Dump ("d5");

// See "Formatting & Parsing" for constructing a DateTime from a string

