<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

try
{
	var query = from i in ParallelEnumerable.Range (0, 1000000)
				select 100 / i;
	// Enumerate query
	query.Dump();
}
catch (AggregateException aex)
{
	foreach (Exception ex in aex.InnerExceptions)
		Console.WriteLine (ex.Message);
}
