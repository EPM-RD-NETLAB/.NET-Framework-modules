<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

ParameterExpression p = Expression.Parameter (typeof (string), "text");
MemberExpression stringLength = Expression.Property (p, "Length");
ConstantExpression five = Expression.Constant (5);
BinaryExpression comparison = Expression.LessThan (stringLength, five);
Expression<Func<string, bool>> lambda = Expression.Lambda<Func<string, bool>>(comparison, p);

Func<string, bool> runnable = lambda.Compile();
Console.WriteLine (runnable ("Hello"));
Console.WriteLine (runnable ("dog"));