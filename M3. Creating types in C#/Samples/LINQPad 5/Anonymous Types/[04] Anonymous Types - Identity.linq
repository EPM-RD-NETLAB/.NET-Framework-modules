<Query Kind="Statements" />

// Two anonymous type instances will have the same underlying type if their elements are 
// same-typed and they’re declared within the same assembly

var a1 = new { X = 2, Y = 4 };
var a2 = new { X = 2, Y = 4 };
Console.WriteLine (a1.GetType() == a2.GetType());   // True

// Additionally, the Equals method is overridden to perform equality comparisons:

Console.WriteLine (a1 == a2);         // False
Console.WriteLine (a1.Equals (a2));   // True
