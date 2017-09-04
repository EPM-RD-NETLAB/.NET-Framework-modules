<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// Creating a custom NumberFormatInfo:
NumberFormatInfo f = new NumberFormatInfo ();
f.NumberGroupSeparator = " ";
Console.WriteLine (12345.6789.ToString ("N3", f));   // 12 345.679

// Cloning:
NumberFormatInfo f2 = (NumberFormatInfo) CultureInfo.CurrentCulture.NumberFormat.Clone();

// Now we can edit f2:
f2.NumberGroupSeparator = "*";
Console.WriteLine (12345.6789.ToString ("N3", f2));   // 12 345.679