<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

ParallelEnumerable.Range (1, 10000000)
				  .Sum (i => Math.Sqrt (i))
