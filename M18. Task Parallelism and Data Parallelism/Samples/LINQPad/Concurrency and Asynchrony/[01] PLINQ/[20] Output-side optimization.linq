<Query Kind="Statements">
  <Namespace>System.Net</Namespace>
</Query>

"abcdef".AsParallel().Select (c => char.ToUpper(c)).ForAll (Console.Write);