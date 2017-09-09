<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var cts = new CancellationTokenSource();
CancellationToken token = cts.Token;
cts.CancelAfter (500);

Task task = Task.Factory.StartNew (() => 
{
	Thread.Sleep (1000);
	token.ThrowIfCancellationRequested();  // Check for cancellation request
}, token);

try { task.Wait(); }
catch (AggregateException ex)
{
	Console.WriteLine (ex.InnerException is TaskCanceledException);  // True
	Console.WriteLine (task.IsCanceled);                             // True
	Console.WriteLine (task.Status);                             // Canceled
}
