<Query Kind="Statements" />

// Here's how to declare a jagged array (an array of arrays):

int [][] matrix = new int [3][];

// The inner dimensions aren’t specified in the declaration. Unlike a rectangular array, each inner array
// can be an arbitrary length. Each inner array is implicitly initialized to null rather than an empty array.
// Each inner array must be created manually:

for (int i = 0; i < matrix.Length; i++)
{
	matrix[i] = new int [3];                    // Create inner array
	for (int j = 0; j < matrix[i].Length; j++)
		matrix[i][j] = i * 3 + j;
}

matrix.Dump ("Populated manually");

// A jagged array can be initialized as follows:

int[][] matrix2 = new int[][]
{
  new int[] {0,1,2},
  new int[] {3,4,5},
  new int[] {6,7,8,9}
};

matrix2.Dump ("Populated via array initialization expression");