<Query Kind="Statements">
  <Connection>
    <ID>96588473-8f7e-4c8a-8f50-58e89091256d</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
    <AttachFileName>C:\Users\kravchuk\Desktop\Kravchuk\IT\ASP.NET Web Forms materials\10267\10267\Labfiles\Solution\M8\CS\CustomerManagement\App_Data\CustomerManagement.mdf</AttachFileName>
  </Connection>
</Query>

// Sequence operators form first-class queries that 
// are not executed until you enumerate over them. 
  
int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
  
int i = 0; 
var q = 
		from n in numbers 
		select ++i; 
  
// Note, the local variable 'i' is not incremented 
// until each element is evaluated (as a side-effect): 
foreach (var v in q) 
{ 
	Console.WriteLine("v = {0}, i = {1}", v, i); 
} 