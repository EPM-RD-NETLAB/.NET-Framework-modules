<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
</Query>

{
	int i = 0;
	(from n in Enumerable.Range(0,999).AsParallel() select n * i++).Dump ("unsafe");
}

{
	Enumerable.Range(0,999).AsParallel().Select ((n, i) => n * i).Dump ("safe");
}

