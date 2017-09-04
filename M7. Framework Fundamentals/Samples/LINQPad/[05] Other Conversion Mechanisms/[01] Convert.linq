<Query Kind="Statements" />

double d = 3.9;
int i = Convert.ToInt32 (d);
i.Dump();

int thirty = Convert.ToInt32  ("1E", 16);    // Parse in hexadecimal
uint five  = Convert.ToUInt32 ("101", 2);    // Parse in binary

thirty.Dump(); five.Dump();

// Dynamic conversions:

Type targetType = typeof (int);
object source = "42";

object result = Convert.ChangeType (source, targetType);

Console.WriteLine (result);             // 42
Console.WriteLine (result.GetType());   // System.Int32

// Base-64 conversions:

Convert.ToBase64String (new byte[] { 123, 5, 33, 210 }).Dump();
Convert.FromBase64String ("ewUh0g==").Dump();