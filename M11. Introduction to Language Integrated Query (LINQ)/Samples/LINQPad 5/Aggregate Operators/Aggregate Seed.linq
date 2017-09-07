<Query Kind="Statements" />

double startBalance = 100.0; 
  
int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 }; 
  
double endBalance = 
		attemptedWithdrawals.Aggregate(
		startBalance,(balance, nextWithdrawal) => 
				((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance)); 
  
Console.WriteLine("Ending balance: {0}", endBalance);