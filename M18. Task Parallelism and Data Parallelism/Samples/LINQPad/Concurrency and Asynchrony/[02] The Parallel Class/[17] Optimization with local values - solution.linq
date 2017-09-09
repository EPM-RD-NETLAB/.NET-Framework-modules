<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

object locker = new object();
double grandTotal = 0;

Parallel.For (1, 10000000,

	() => 0.0,                         // Initialize the local value.
	
	(i, state, localTotal) =>          // Body delegate. Notice that it
		localTotal + Math.Sqrt (i),    // returns the new local total.
	
	localTotal =>                                      // Add the local value
		{ lock (locker) grandTotal += localTotal; }    // to the master value.
);

grandTotal.Dump();