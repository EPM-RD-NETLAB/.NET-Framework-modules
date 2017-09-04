<Query Kind="Statements" />

// All array indexing is bounds-checked by the runtime:

int[] arr = new int[3];
arr[3] = 1;               // IndexOutOfRangeException thrown
