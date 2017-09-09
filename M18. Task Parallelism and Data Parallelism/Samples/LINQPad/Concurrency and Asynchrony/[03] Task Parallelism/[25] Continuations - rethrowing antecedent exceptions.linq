<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task continuation = Task.Factory.StartNew     (()  => { throw null; })
								.ContinueWith (ant =>
	{
		if (ant.Exception != null) throw ant.Exception;
		// Continue processing...
	});

continuation.Wait();    // Exception is now thrown back to caller.
