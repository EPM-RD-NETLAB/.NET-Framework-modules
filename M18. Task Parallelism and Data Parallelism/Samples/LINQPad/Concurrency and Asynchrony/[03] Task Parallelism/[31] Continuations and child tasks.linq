<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
Task.Factory.StartNew (() =>
{
	Task.Factory.StartNew (() => { throw null; }, atp);
	Task.Factory.StartNew (() => { throw null; }, atp);
	Task.Factory.StartNew (() => { throw null; }, atp);
})
.ContinueWith (p => Console.WriteLine (p.Exception),
					TaskContinuationOptions.OnlyOnFaulted)

.Wait(); // throws AggregateException containing three NullReferenceExceptions