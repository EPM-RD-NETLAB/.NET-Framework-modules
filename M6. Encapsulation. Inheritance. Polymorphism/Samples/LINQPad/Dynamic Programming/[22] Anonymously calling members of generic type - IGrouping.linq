<Query Kind="Program">
  
</Query>

string GetGroupKey<TKey,TElement> (IGrouping<TKey,TElement> group)
{
	return "Group with key=" + group.Key + ": ";
}

string GetGroupKey (object source) { return null; }

string ToStringEx (object value)
{
	if (value == null) return "<null>";
	if (value is string) return (string) value;
	if (value.GetType().IsPrimitive) return value.ToString();
	
	StringBuilder sb = new StringBuilder();
	
	string groupKey = GetGroupKey ((dynamic)value);   // Dynamic dispatch
	if (groupKey != null) sb.Append (groupKey);
	
	if (value is IEnumerable)
		foreach (object element in ((IEnumerable)value))
			sb.Append (ToStringEx (element) + " ");
	
	if (sb.Length == 0) sb.Append (value.ToString());
	
	return "\r\n" + sb.ToString();
}

void Main()
{
	ToStringEx ("xyyzzz".GroupBy (c => c)).Dump();
}