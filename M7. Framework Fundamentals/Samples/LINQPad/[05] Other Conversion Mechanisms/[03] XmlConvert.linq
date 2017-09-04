<Query Kind="Statements" />

// XmlConvert honors XML formatting rules:

string s = XmlConvert.ToString (true);
s.Dump();									// true (rather than True)
XmlConvert.ToBoolean (s).Dump();

DateTime dt = DateTime.Now;
XmlConvert.ToString (dt, XmlDateTimeSerializationMode.Local).Dump ("local");
XmlConvert.ToString (dt, XmlDateTimeSerializationMode.Utc).Dump ("Utc");
XmlConvert.ToString (dt, XmlDateTimeSerializationMode.RoundtripKind).Dump ("RoundtripKind");

XmlConvert.ToString (DateTimeOffset.Now).Dump ("DateTimeOffset");