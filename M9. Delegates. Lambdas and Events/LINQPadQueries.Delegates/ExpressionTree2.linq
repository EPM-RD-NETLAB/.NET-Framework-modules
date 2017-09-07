<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//code as data
Expression<Func<string,bool>> returnLength = text => text.Length < 5;
// LIMITATIONS - You can’t convert a lambda with a block of statements 
//(even just one return statement) into an expression tree — it has to be
//in the form that evaluates a single expression
//Console.WriteLine(returnLength("Hello"));
//var returnLength = text => text.Length;//CTE ?
//returnLength.Dump();
var compileDelegate = returnLength.Compile();
//compileDelegate.Dump();
Console.WriteLine(compileDelegate("Hello"));
Console.WriteLine(compileDelegate("Dog"));
//NodeType - element of enum ExpressionType