<Query Kind="Program" />

enum EmployeTypes
{
	Programmer,
	Editor
}

class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public EmployeTypes EmployeType { get; set; }
}

void Main()
{
	XElement firstName = new XElement("FirstName","Alex");
	firstName.Dump("firstName");
	//	Объект XName создается неявным преобразованием входного параметра string в XName
	//	Второй аргумент — единственный объект, представляющий содержимое элемента.
	//	API-интерфейс "на лету" преобразует этот строковый литерал "Alex" в объект XText
	Console.WriteLine((string)firstName);
	Console.WriteLine(firstName);
	Console.WriteLine();
	
	//Если при создании объекта XElement в качестве объекта содержимого указано int, 
	//то приведением узла к int получится значение, преобразованное в int. 
	//До тех пор пока выполняется приведение к одному из типов, для которых предусмотрена
	//операция приведения, и пока значение элемента может быть преобразовано в тип, 
	//к которому выполняется приведение, такая операция представляет простой способ
	//получения значения элемента
	XElement dataElem = new XElement("data",2012);
	((int)dataElem).Dump();
	dataElem.Dump();
	XElement dt = new XElement("OK", true);
	((bool)dt).Dump();
	dt.Dump();
	Console.WriteLine();
	
	//Мощь функционального конструирования
	Employee[] emps = new[] { 
						new Employee { FirstName = "Alex", LastName="Erohin", EmployeType=EmployeTypes.Programmer},
						new Employee { FirstName="Elena", LastName="Volkova", EmployeType=EmployeTypes.Editor}};
	
	XElement xEmp = 
					new XElement("Employees",
						emps.Select(p =>
							new XElement("Employee",
								new XAttribute("type", p.EmployeType),
								new XElement("FirstName", p.FirstName),
								new XElement("LastName", p.LastName))));
	xEmp.Dump();
}