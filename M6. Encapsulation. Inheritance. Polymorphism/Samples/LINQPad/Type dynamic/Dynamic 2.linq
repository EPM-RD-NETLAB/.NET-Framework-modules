<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Person 
{ 
	public string FirstName { get; set; } 
	public string LastName { get; set; } 
	public string GetFullName() 
	{ 
		return string.Concat(FirstName, " ", LastName); 
	} 
} 

void Main()
{
	var staticPerson = new Person (); 
	dynamic dynamicPerson = new Person (); 
	//staticPerson.GetFullName("John", "Smith"); //CTR!
	dynamicPerson.GetFullName("John", "Smith"); 
}