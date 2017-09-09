<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task.Delay (5000).GetAwaiter().OnCompleted (() => Console.WriteLine (42));

// Another way to attach a continuation:
Task.Delay (5000).ContinueWith (ant => Console.WriteLine (42));
