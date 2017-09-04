<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The easiest way to instantiate a correctly configured encoding class is to 
// call Encoding.GetEncoding with a standard IANA name:

Encoding utf8 = Encoding.GetEncoding ("utf-8");
Encoding chinese = Encoding.GetEncoding ("GB18030");

utf8.Dump();
chinese.Dump();

// The static GetEncodings method returns a list of all supported encodings:
foreach (EncodingInfo info in Encoding.GetEncodings())
	Console.WriteLine (info.Name);