<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// There’s no standard interface for parsing through a format provider; instead use Parse/TryParse methods
// on the target types:

try 
{
	int error = int.Parse ("(2)");   // Exception thrown
}
catch (FormatException ex) { ex.Dump(); }	

int minusTwo = int.Parse ("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses);   // OK
minusTwo.Dump();

decimal fivePointTwo = decimal.Parse ("£5.20", NumberStyles.Currency, CultureInfo.GetCultureInfo ("en-GB"));
fivePointTwo.Dump();
