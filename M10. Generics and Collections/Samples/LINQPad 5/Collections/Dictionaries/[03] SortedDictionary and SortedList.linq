<Query Kind="Statements">
  
</Query>

// MethodInfo is in the System.Reflection namespace

var sorted = new SortedList <string, MethodInfo>();

foreach (MethodInfo m in typeof (object).GetMethods())
	sorted [m.Name] = m;

sorted.Keys.Dump ("keys");
sorted.Values.Dump ("values");

foreach (MethodInfo m in sorted.Values)
	Console.WriteLine (m.Name + " returns a " + m.ReturnType);

Console.WriteLine (sorted ["GetHashCode"]);      // Int32 GetHashCode()

Console.WriteLine (sorted.Keys  [sorted.Count - 1]);            // ToString
Console.WriteLine (sorted.Values[sorted.Count - 1].IsVirtual);  // True
