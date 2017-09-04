<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	foreach (char c in "gfdx")
		Format (c.ToString());	
}

void Format (string formatString)
{
	System.ConsoleColor.Red.ToString (formatString).Dump ("ToString (\"" + formatString + "\")");
}
