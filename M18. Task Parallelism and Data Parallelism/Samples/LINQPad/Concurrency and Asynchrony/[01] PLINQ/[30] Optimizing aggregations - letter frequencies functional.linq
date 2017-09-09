<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

string text = "Let’s suppose this is a really long string";

int[] result =
	text.Aggregate (
		new int[26],                // Create the "accumulator"
		(letterFrequencies, c) =>   // Aggregate a letter into the accumulator
		{
			int index = char.ToUpper (c) - 'A';
			if (index >= 0 && index <= 26) letterFrequencies [index]++;
			return letterFrequencies;
		});

result.Dump();