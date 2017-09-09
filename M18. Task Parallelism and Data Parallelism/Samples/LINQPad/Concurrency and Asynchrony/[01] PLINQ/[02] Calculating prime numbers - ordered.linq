<Query Kind="Statements" />

// Calculate prime numbers with ordered output.

IEnumerable<int> numbers = Enumerable.Range (3, 1000000-3);

var parallelQuery = 
	from n in numbers.AsParallel().AsOrdered()
	where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
	select n;

int[] primes = parallelQuery.ToArray();
primes.Take(100).Dump();

// In this example, we could alternatively call OrderBy at the end of the query.