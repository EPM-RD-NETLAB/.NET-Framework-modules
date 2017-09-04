<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The format string provides instructions; the format provider determines how the instructions are translated:
NumberFormatInfo f = new NumberFormatInfo();
f.CurrencySymbol = "$$";
Console.WriteLine (3.ToString ("C", f));          // $$ 3.00

// The default format provider is CultureInfo.CurrentCulture:
Console.WriteLine (10.3.ToString ("C", null));

// For convenience, most types overload ToString such that you can omit a null provider:
Console.WriteLine (10.3.ToString ("C"));
Console.WriteLine (10.3.ToString ("F4"));		// (Fix to 4 D.P.)
