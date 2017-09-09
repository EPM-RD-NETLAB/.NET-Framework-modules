<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

Parallel.ForEach ("Hello, world", (c, state, i) =>
{
	Console.WriteLine (c.ToString() + i);
});
