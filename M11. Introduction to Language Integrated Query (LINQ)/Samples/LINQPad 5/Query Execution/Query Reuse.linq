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

// Отложенное выполнение позволяет определить запрос один раз
// А затем использовать его позже, после изменения данных.
  
int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
var lowNumbers = 
		from n in numbers 
		where n <= 3 
		select n; 
  
lowNumbers.Dump("First run numbers <= 3:"); //foreach
  
for (int i = 0; i < 10; i++) 
{ 
	numbers[i] = -numbers[i]; 
} 
  
// During this second run, the same query object, 
// lowNumbers, will be iterating over the new state 
// of numbers[], producing different results: 
Console.WriteLine("Second run numbers <= 3:"); 
lowNumbers.Dump("First run numbers <= 3:"); 