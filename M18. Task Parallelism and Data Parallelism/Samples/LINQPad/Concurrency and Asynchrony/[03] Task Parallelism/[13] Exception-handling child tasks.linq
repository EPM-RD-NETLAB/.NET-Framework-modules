<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
var parent = Task.Factory.StartNew (() => 
{
	Task.Factory.StartNew (() =>   // Child
	{
		Task.Factory.StartNew (() => { throw null; }, atp);   // Grandchild
	}, atp);
});

// The following call throws a NullReferenceException (wrapped
// in nested AggregateExceptions):
parent.Wait();
