<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Builds up parts method call
MethodInfo method = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });

var target = Expression.Parameter(typeof(string), "x");

var methodArg = Expression.Parameter(typeof(string), "y");

Expression[] methodArgs = new[] { methodArg };

//Creates CallExpression from parts
Expression call = Expression.Call(target, method, methodArgs);

//onverts call into LambdaExpression
var lambdaParameters = new[] { target, methodArg };

var lambda = Expression.Lambda<Func<string, string, bool>>(call, lambdaParameters);

var compiled = lambda.Compile();

Console.WriteLine(compiled("First", "Second"));
Console.WriteLine(compiled("First", "Fir"));