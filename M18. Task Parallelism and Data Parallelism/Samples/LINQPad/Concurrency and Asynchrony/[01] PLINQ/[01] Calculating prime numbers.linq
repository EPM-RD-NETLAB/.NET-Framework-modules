<Query Kind="Statements" />

// Calculate prime numbers using a simple (unoptimized) algorithm.
// This calculates prime numbers between 3 and a million, using all available cores:

IEnumerable<int> numbers = Enumerable.Range (3, 1000000-3);

var parallelQuery = 
	from n in numbers.AsParallel()
	where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
	select n;

int[] primes = parallelQuery.ToArray();
primes.Take(100).Dump();