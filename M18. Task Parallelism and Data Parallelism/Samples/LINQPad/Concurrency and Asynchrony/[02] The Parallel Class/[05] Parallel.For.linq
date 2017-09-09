<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

var keyPairs = new string[6];

Parallel.For (0, keyPairs.Length,
			  i => keyPairs[i] = RSA.Create().ToXmlString (true));

keyPairs.Dump();