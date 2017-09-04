<Query Kind="Statements" />

object objExample = 10;
Console.WriteLine(objExample.GetType());

objExample = (int)objExample + 10;//casting!

objExample = "test";
Console.WriteLine(objExample.GetType());