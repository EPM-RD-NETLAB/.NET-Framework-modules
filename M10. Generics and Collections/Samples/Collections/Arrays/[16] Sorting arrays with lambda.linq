<Query Kind="Statements">
  
</Query>

// Sort such that odd numbers come first:
int[] numbers = { 1, 2, 3, 4, 5 };
Array.Sort (numbers, (x, y) => x % 2 == y % 2 ? 0 : x % 2 == 1 ? -1 : 1);
numbers.Dump();