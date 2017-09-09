<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

int[] numbers = { 3, 4, 5, 6, 7, 8, 9 };

var parallelQuery =
	Partitioner.Create (numbers, true).AsParallel()
	.Where (n => n % 2 == 0);
	
parallelQuery.Dump();	
