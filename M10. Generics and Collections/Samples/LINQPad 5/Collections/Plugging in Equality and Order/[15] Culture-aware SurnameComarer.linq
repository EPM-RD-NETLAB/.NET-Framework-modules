<Query Kind="Program">
  
  <Namespace>System.Globalization</Namespace>
</Query>

class SurnameComparer : Comparer <string>
{
	StringComparer strCmp;

	public SurnameComparer (CultureInfo ci)
	{
		// Create a case-sensitive, culture-sensitive string comparer
		strCmp = StringComparer.Create (ci, false);
	}

	string Normalize (string s)
	{
		s = s.Trim();
		if (s.ToUpper().StartsWith ("MC")) s = "MAC" + s.Substring (2);
		return s;
	}

	public override int Compare (string x, string y)
	{
		// Directly call Compare on our culture-aware StringComparer
		return strCmp.Compare (Normalize (x), Normalize (y));
	}
}

void Main()
{
	var dic = new SortedDictionary<string,string> (new SurnameComparer(CultureInfo.GetCultureInfo ("de-DE")));
	dic.Add ("MacPhail", "second!");
	dic.Add ("MacWilliam", "third!");
	dic.Add ("McDonald", "first!");
	dic.Dump();
}
