<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var factory = new TaskFactory (
	TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent,
	TaskContinuationOptions.None);

Task task1 = factory.StartNew (() => "foo".Dump());
Task task2 = factory.StartNew (() => "far".Dump());

