<Query Kind="Statements" />

char[] vowels = {'a','e','i','o','u'};

// We can omit the "new" expression after the assignment operator:

int[,] rectangularMatrix =
{
	{0,1,2},
	{3,4,5},
	{6,7,8}
};

int[][] jaggedMatrix =
{
	new int[] {0,1,2},
	new int[] {3,4,5},
	new int[] {6,7,8}
};

rectangularMatrix.Dump(); jaggedMatrix.Dump();