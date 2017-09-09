<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var parent = Task.Factory.StartNew (() => 
{
	// We’ll throw 3 exceptions at once using 3 child tasks:
	
	int[] numbers = { 0 };
	
	var childFactory = new TaskFactory
	(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.None);
	
	childFactory.StartNew (() => 5 / numbers[0]);   // Division by zero
	childFactory.StartNew (() => numbers [1]);      // Index out of range
	childFactory.StartNew (() => { throw null; });  // Null reference
});

try { parent.Wait(); }
catch (AggregateException aex)
{
	aex.Flatten().Handle (ex =>   // Note that we still need to call Flatten
	{
		if (ex is DivideByZeroException)
		{
			Console.WriteLine ("Divide by zero");
			return true;                           // This exception is "handled"
		}
		if (ex is IndexOutOfRangeException)
		{
			Console.WriteLine ("Index out of range");
			return true;                           // This exception is "handled"   
		}
		return false;    // All other exceptions will get rethrown
	});
}
