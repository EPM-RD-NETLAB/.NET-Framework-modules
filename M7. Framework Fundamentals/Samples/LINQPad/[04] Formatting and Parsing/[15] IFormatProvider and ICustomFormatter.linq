<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

static void Main()
{
	double n = -123.45;
	IFormatProvider fp = new WordyFormatProvider();
	Console.WriteLine (string.Format (fp, "{0:C} in words is {0:W}", n));
}

public class WordyFormatProvider : IFormatProvider, ICustomFormatter
{
	static readonly string[] _numberWords =
		"zero one two three four five six seven eight nine minus point".Split();
	
	IFormatProvider _parent;   // Allows consumers to chain format providers
	
	public WordyFormatProvider () : this (CultureInfo.CurrentCulture) { }
	public WordyFormatProvider (IFormatProvider parent)
	{
		_parent = parent;
	}
	
	public object GetFormat (Type formatType)
	{
		if (formatType == typeof (ICustomFormatter)) return this;
		return null;
	}
	
	public string Format (string format, object arg, IFormatProvider prov)
	{
		// If it's not our format string, defer to the parent provider:
		if (arg == null || format != "W")
		return string.Format (_parent, "{0:" + format + "}", arg);
	
		StringBuilder result = new StringBuilder();
		string digitList = string.Format (CultureInfo.InvariantCulture, "{0}", arg);
		foreach (char digit in digitList)
		{
			int i = "0123456789-.".IndexOf (digit);
			if (i == -1) continue;
			if (result.Length > 0) result.Append (' ');
			result.Append (_numberWords[i]);
		}
		return result.ToString();
	}
}
