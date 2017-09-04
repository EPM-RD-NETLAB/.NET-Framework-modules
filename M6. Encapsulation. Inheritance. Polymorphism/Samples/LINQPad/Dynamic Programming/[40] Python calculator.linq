<Query Kind="Program">
  
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.Core.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\Microsoft.Scripting.dll</Reference>
  <Reference>&lt;ApplicationData&gt;\LINQPad\Samples\C# 6.0 in a Nutshell - More Chapters\IronPython.dll</Reference>
  <Namespace>Microsoft.Scripting.Hosting</Namespace>
  <Namespace>IronPython.Hosting</Namespace>
</Query>

static void Main()
{
	int result = (int) Calculate ("2 * 3");
	Console.WriteLine (result);              // 6
	
	var list = (IEnumerable) Calculate ("[1, 2, 3] + [4, 5]");
	foreach (int n in list) Console.Write (n);  // 12345
}
	
static object Calculate (string expression)
{
	ScriptEngine engine = Python.CreateEngine();
	return engine.Execute (expression);
}
