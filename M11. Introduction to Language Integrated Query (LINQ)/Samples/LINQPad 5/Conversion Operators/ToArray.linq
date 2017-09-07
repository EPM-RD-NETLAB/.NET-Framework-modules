<Query Kind="Statements" />

//double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 }; 
List<double> doubles = new List<double>( new double[]{ 1.7, 2.3, 1.9, 4.1, 2.9 });
var sortedDoubles = 
		from d in doubles 
		orderby d descending 
		select d; 
		
sortedDoubles.Dump("iterator");
		
var doublesArray = sortedDoubles.ToArray(); 
  
doublesArray.Dump("array");

doubles.Add(-12.56);
sortedDoubles.Dump("iterator");
doublesArray.Dump("array");