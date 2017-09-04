<Query Kind="Statements">
  
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.Core.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\IronPython.dll</Reference>
  <Namespace>Microsoft.Scripting.Hosting</Namespace>
  <Namespace>IronPython.Hosting</Namespace>
  <Namespace>Microsoft.Scripting</Namespace>
</Query>

// The following string could come from a file or database:
string auditRule = "taxPaidLastYear / taxPaidThisYear > 2";

ScriptEngine engine = Python.CreateEngine ();    

ScriptScope scope = engine.CreateScope ();        
scope.SetVariable ("taxPaidLastYear", 20000m);
scope.SetVariable ("taxPaidThisYear", 8000m);

ScriptSource source = engine.CreateScriptSourceFromString (auditRule, SourceCodeKind.Expression);

bool auditRequired = (bool) source.Execute (scope);
Console.WriteLine (auditRequired);   // True
