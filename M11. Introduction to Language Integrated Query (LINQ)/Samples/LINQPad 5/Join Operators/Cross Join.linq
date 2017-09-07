<Query Kind="Program">
  <Connection>
    <ID>96588473-8f7e-4c8a-8f50-58e89091256d</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
    <AttachFileName>C:\Users\kravchuk\Desktop\Kravchuk\IT\ASP.NET Web Forms materials\10267\10267\Labfiles\Solution\M8\CS\CustomerManagement\App_Data\CustomerManagement.mdf</AttachFileName>
  </Connection>
</Query>

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
	IEnumerable<Company> companies = new[]
				 {
					 new Company {CompanyName = "Contoso", Country = "United Kingdom"},
					 new Company {CompanyName = "Fabrikam", Country = "United States"}
				 };
	companies.Dump("Companies");			 
//	var customersAndCompanies = customers.Join(
//	 			companies,
//				custs => custs.CompanyName,
//				comps => comps.CompanyName,
//				(custs, comps) => new { custs.FirstName, custs.LastName, comps.Country });//.OrderByDescending(cust=>cust.FirstName);
	
	var customersAndCompanies = 
							from customer in customers
							join company in companies on customer.CompanyName equals company.CompanyName
							select new { customer.FirstName, customer.LastName, company.Country };
	customersAndCompanies.Dump("Customers join Companies");
}