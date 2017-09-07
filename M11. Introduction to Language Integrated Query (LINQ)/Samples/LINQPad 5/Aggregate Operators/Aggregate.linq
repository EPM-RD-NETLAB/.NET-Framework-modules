<Query Kind="Statements" />

double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 }; 
  
double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor); 
  
Console.WriteLine("Total product of all numbers: {0}", product);