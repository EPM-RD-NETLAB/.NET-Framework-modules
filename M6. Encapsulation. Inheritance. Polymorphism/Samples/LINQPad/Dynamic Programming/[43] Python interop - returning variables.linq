<Query Kind="Statements">
  
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.Core.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\IronPython.dll</Reference>
  <Namespace>Microsoft.Scripting.Hosting</Namespace>
  <Namespace>IronPython.Hosting</Namespace>
  <Namespace>Microsoft.Scripting</Namespace>
</Query>

string code = "result = input * 3";

ScriptEngine engine = Python.CreateEngine();

ScriptScope scope = engine.CreateScope();
scope.SetVariable ("input", 2);

ScriptSource source = engine.CreateScriptSourceFromString (code, SourceCodeKind.SingleStatement);
source.Execute (scope);
Console.WriteLine (engine.GetVariable (scope, "result"));   // 6
