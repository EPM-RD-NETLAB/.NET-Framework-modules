<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

ParallelEnumerable.Range (0, 6)
	.Select (i => RSA.Create().ToXmlString (true))
	.ToArray()
	
