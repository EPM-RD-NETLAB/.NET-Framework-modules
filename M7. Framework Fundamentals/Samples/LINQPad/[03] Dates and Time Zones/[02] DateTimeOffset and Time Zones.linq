<Query Kind="Statements" />

// Comparisons look only at the (UTC) DateTime; the Offset is used primarily for formatting.

DateTimeOffset local = DateTimeOffset.Now;
DateTimeOffset utc   = local.ToUniversalTime();

Console.WriteLine (local.Offset);   // -06:00:00 (in Central America)
Console.WriteLine (utc.Offset);     // 00:00:00

Console.WriteLine (local == utc);                 // True

//To include the Offset in the comparison, you must use the EqualsExact method:

Console.WriteLine (local.EqualsExact (utc));      // False
