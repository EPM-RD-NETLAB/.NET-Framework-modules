<Query Kind="Statements" />

// The var keyword tells the compiler to implicitly type a local variable:

var i = 3;           // i is implicitly of type int
var s = "sausage";   // s is implicitly of type string

// Therefore:
var rectMatrix = new int[,]    // rectMatrix is implicitly of type int[,]
{
	{0,1,2},
	{3,4,5},
	{6,7,8}
};

var jaggedMat = new int[][]    // jaggedMat is implicitly of type int[][]
{
	new int[] {0,1,2},
	new int[] {3,4,5},
	new int[] {6,7,8}
};

// Implicit typing can be taken one stage further with single-dimensional arrays. You can omit
// the type qualifier after the new keyword and have the compiler infer the array type:

var vowels = new[] {'a','e','i','o','u'};   // Compiler infers char[]
var x = new[] { 1, 10000000000 };   // Legal - all elements are convertible to long

vowels.Dump(); x.Dump();