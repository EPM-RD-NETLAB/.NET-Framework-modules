<Query Kind="Statements" />

int[] numbers = { 1, 11, 3, 19, 41, 65, 19 }; 
numbers.All(n => n % 2 == 1).Dump("The list contains only odd numbers:");