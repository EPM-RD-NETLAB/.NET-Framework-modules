<Query Kind="Statements" />

// The following all honor local culture settings:

DateTime.Now.ToString().Dump ("Short date followed by long time");
DateTimeOffset.Now.ToString().Dump ("Short date followed by long time (+ timezone)");

DateTime.Now.ToShortDateString().Dump ("ToShortDateString");
DateTime.Now.ToShortTimeString().Dump ("ToShortTimeString");

DateTime.Now.ToLongDateString().Dump ("ToLongDateString");
DateTime.Now.ToLongTimeString().Dump ("ToLongTimeString");

// Culture-agnostic methods make for reliable formatting & parsing:

DateTime dt1 = DateTime.Now;
string cannotBeMisparsed = dt1.ToString ("o");
DateTime dt2 = DateTime.Parse (cannotBeMisparsed);
dt2.Dump();