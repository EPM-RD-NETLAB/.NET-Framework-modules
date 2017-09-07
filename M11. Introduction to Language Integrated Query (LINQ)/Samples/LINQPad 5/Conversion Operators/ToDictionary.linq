<Query Kind="Statements" />

var scoreRecords = new[] 
						{ 
							new {Name = "Alice", Score = 50}, 
							new {Name = "Bob"  , Score = 40}, 
							new {Name = "Cathy", Score = 45} 
						}; 
  
var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name); 
  
Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]); 