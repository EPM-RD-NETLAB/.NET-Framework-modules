<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

string text = "Let’s suppose this is a really long string";
var letterFrequencies = new int[26];
foreach (char c in text)
{
	int index = char.ToUpper (c) - 'A';
	if (index >= 0 && index <= 26) letterFrequencies [index]++;
};
letterFrequencies.Dump();