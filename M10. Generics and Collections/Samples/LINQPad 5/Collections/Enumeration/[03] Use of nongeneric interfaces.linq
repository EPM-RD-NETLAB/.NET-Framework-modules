<Query Kind="Program">
  
</Query>

void Main()
{
	Count ("the quick brown fix".Split()).Dump();
}

public static int Count (IEnumerable e)
{
	int count = 0;
	foreach (object element in e)
	{
		var subCollection = element as IEnumerable;
		if (subCollection != null)
			count += Count (subCollection);
		else
			count++;
	}
	return count;
}

