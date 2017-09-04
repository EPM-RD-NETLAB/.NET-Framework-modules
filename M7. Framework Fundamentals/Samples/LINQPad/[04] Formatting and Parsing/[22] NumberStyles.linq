<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

int thousand = int.Parse ("3E8", NumberStyles.HexNumber);
int minusTwo = int.Parse ("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses);
								 
double.Parse ("1,000,000", NumberStyles.Any).Dump ("million");
decimal.Parse ("3e6", NumberStyles.Any).Dump ("3 million");
decimal.Parse ("$5.20", NumberStyles.Currency).Dump ("5.2");

NumberFormatInfo ni = new NumberFormatInfo();
ni.CurrencySymbol = "€";
ni.CurrencyGroupSeparator = " ";
double.Parse ("€1 000 000", NumberStyles.Currency, ni).Dump ("million");
