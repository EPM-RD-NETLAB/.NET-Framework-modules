<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
numbers.SkipWhile((n, index) => n >= index).Dump("All elements starting from first element less than its position:"); 