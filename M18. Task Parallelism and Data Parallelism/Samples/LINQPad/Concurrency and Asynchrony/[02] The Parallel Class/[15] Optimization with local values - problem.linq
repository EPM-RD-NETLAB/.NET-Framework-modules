<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

object locker = new object();
double total = 0;
Parallel.For (1, 10000000,
			  i => { lock (locker) total += Math.Sqrt (i); });
total.Dump();