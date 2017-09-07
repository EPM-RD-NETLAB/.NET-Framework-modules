<Query Kind="Program" />

class SurnameComparer : Comparer <string>
{
	string Normalize (string s)
	{
		s = s.Trim().ToUpper();
		if (s.StartsWith ("MC")) s = "MAC" + s.Substring (2);
		return s;
	}

	public override int Compare (string x, string y)
		=> Normalize (x).CompareTo (Normalize (y));
}

void Main()
{
	var dic = new SortedDictionary<string,string> (new SurnameComparer());
	dic.Add ("MacPhail", "second!");
	dic.Add ("MacWilliam", "third!");
	dic.Add ("McDonald", "first!");
	dic.Dump();
}