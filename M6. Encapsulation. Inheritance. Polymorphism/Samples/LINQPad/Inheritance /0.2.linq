<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Employee empl = new Employee("First");
	empl.Dump();
	//empl.GetType().Dump();
	object obj = empl;//полиморфное присоединение
	empl.ObtainSalary().Dump("Salary");
	Calculate(empl);
	//obj.GetType().Dump();
	
	Manager mng = new Manager("First","Vip");
	mng.Dump();
	mng.ObtainSalary().Dump("Salary");
	Calculate(mng);
	//mng.GetType().Dump();
	//empl = mng;
	//empl.GetType().Dump();
	
	VipManager vpm = new VipManager("First","Vip","Super");
	vpm.Dump();
	vpm.ObtainSalary().Dump("Salary");
	Calculate(vpm);
	//vpm.GetType().Dump();
	//obj = vpm;
	//obj.GetType().Dump();
	"====================".Dump();
	Employee[] employees = {empl, mng, vpm, empl, mng, vpm};
	Calculate(employees);
}
class Employee
{
    //private string empName;
	public string Name { get; set; }
	public Employee() {}
    public Employee(string name) 
    {
        this.Name = name;
    }

	public decimal ObtainSalary()
	{
		return 1000m;
	}
}
 
class Manager : Employee
{
    //private string empGrade;
	public string Grade { get; set; }
    public Manager(string name, string grade) : base(name)
    {
        this.Grade = grade;
    }

	public new decimal ObtainSalary()
	{
		return 5000m;
	}
}

class VipManager : Manager
{
	public string VipGrade { get; set; }
	public VipManager(string name, string grade, string vip) : base(name, grade)
	{
		this.VipGrade = vip;
	}

	public new decimal ObtainSalary()
	{
		return 10000m;
	}
}

void Calculate(Employee[] employees)
{
	foreach (var employee in employees)
	{
		//Calculate(employee);
		"------------".Dump();
		employee.ObtainSalary().Dump("Salary = ");
	}
}

void Calculate(Employee empl)
{
	if (empl.GetType() == typeof(Employee))
	{
		empl.ObtainSalary().Dump("Salary = ");
	}
	else
	if (empl.GetType() ==  typeof(Manager))
	{
		Manager mng = (Manager)empl;
		mng.ObtainSalary().Dump("Salary = ");
	}
	else if (empl.GetType() ==  typeof(VipManager))
	{
		VipManager vpm = (VipManager)empl;
		vpm.ObtainSalary().Dump("Salary = ");
	}
}

