<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

Expression<Func<string, string, bool>> expression = (x, y) => x.StartsWith(y);
var compiled = expression.Compile();
Console.WriteLine(compiled("First", "Second"));
Console.WriteLine(compiled("First", "Fir"));