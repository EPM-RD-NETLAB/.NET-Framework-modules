<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

string text = "Let’s suppose this is a really long string";

int[] result =
	text.AsParallel().Aggregate (
		() => new int[26],             // Create a new local accumulator
		
		(localFrequencies, c) =>       // Aggregate into the local accumulator
		{
			int index = char.ToUpper (c) - 'A';
			if (index >= 0 && index <= 26) localFrequencies [index]++;
			return localFrequencies;
		},
										// Aggregate local->main accumulator
		(mainFreq, localFreq) =>
			mainFreq.Zip (localFreq, (f1, f2) => f1 + f2).ToArray(),
		
		finalResult => finalResult     // Perform any final transformation
	);                                 // on the end result.

result.Dump();