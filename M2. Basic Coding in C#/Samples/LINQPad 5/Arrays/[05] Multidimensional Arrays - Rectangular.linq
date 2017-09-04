<Query Kind="Statements" />

// Rectangular arrays represent an n-dimensional block of memory; jagged arrays are arrays of arrays.

int [,] matrix = new int [3, 3];	// 2-dimensional rectangular array

// The GetLength method of an array returns the length for a given dimension (starting at 0):

for (int i = 0; i < matrix.GetLength(0); i++)
	for (int j = 0; j < matrix.GetLength(1); j++)
		matrix [i, j] = i * 3 + j;

matrix.Dump();

// A rectangular array can be initialized as follows:

int[,] matrix2 = new int[,]
{
	{0,1,2},
	{3,4,5},
	{6,7,8}
};

matrix2.Dump();