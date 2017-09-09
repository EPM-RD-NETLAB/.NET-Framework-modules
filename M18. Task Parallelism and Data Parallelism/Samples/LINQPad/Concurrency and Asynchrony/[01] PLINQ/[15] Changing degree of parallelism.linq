<Query Kind="Expression">
  <Namespace>System.Net</Namespace>
</Query>

"The Quick Brown Fox"
	.AsParallel().WithDegreeOfParallelism (2)
	.Where (c => !char.IsWhiteSpace (c))
	.AsParallel().WithDegreeOfParallelism (3)   // Forces Merge + Partition
	.Select (c => char.ToUpper (c))
