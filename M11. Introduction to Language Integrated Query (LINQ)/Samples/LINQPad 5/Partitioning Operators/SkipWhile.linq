<Query Kind="Statements" />

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
numbers.SkipWhile(n => n % 3 != 0).Dump("All elements starting from first element divisible by 3:"); 