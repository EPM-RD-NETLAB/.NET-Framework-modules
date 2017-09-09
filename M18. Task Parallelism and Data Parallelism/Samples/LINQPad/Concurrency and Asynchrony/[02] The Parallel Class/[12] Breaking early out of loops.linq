<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

Parallel.ForEach ("Hello, world", (c, loopState) =>
{
	if (c == ',')
		loopState.Break();
	else
		Console.Write (c);
});
