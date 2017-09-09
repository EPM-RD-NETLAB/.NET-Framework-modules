<Query Kind="Expression">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

new[] { 1, 2, 3 }.AsParallel().Aggregate (
	() => 0,                                     // seedFactory
	(localTotal, n) => localTotal + n,           // updateAccumulatorFunc
	(mainTot, localTot) => mainTot + localTot,   // combineAccumulatorFunc
	finalResult => finalResult)                  // resultSelector
