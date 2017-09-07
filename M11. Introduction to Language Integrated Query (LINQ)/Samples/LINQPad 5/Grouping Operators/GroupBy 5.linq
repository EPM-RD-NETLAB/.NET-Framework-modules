<Query Kind="Program" />

public class Company
{
	public string CompanyName { get; set; }
	public string Country { get; set; }
}

public class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public string CompanyName { get; set; }
}

void Main()
{
	IEnumerable<Customer> customers = new[]
				 {
					 new Customer {FirstName = "Luka", LastName = "Abrus", Age = 41,CompanyName = "Contoso"},
					 new Customer {FirstName = "Syed", LastName = "Abbas", Age = 23,CompanyName  = "Contoso"},
					 new Customer {FirstName = "Keith", LastName = "Harris", Age = 59,CompanyName = "Fabrikam"},
					 new Customer {FirstName = "Keith", LastName = "Harris", Age = 59,CompanyName = "Fabrikam"},
					 new Customer {FirstName = "David", LastName = "Pelton", Age = 25,CompanyName = "Contoso"},
					 new Customer {FirstName = "John", LastName = "Peoples", Age = 37,CompanyName = "Fabrikam"},
					 new Customer {FirstName = "Toni", LastName = "Poe", Age = 29,CompanyName = "Fabrikam"},
					 new Customer {FirstName = "Jeff", LastName = "Price", Age = 74,CompanyName = "Contoso"}
				 };
	customers.Dump("Customers");
	var customersGroupedByAgeRange = customers.GroupBy(cust =>
			{
				if (cust.Age < 20)
					return "age < 20";
				if (cust.Age >= 20 && cust.Age < 40)
					return "age >= 20 and < 40";
				if (cust.Age >= 40 && cust.Age < 60)
					return "age >= 40 and < 60";
				if (cust.Age >= 60)
					return "age >= 60";
				return "Error";
			});
	customersGroupedByAgeRange.Dump("Customers grouped by age range:");	
	
	foreach (var cust in customersGroupedByAgeRange.OrderBy(cust => cust.Key))
	{
		Console.WriteLine("{0}\t\t{1}", cust.Key, cust.Count());
		foreach (Customer customer in cust)
		{
			Console.WriteLine(customer.FirstName);
		}
	}
}