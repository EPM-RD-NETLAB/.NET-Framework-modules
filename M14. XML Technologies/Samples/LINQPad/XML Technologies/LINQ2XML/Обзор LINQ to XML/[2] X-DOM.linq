<Query Kind="Statements" />

// Используем новый API-интерфейс LINQ to XML
//Функциональное конструирование позволяет схеме диктовать то,
//как конструируются объекты XML и инициализируются их значения, 
//и все это — одновременно, в единственном операторе!

XElement xEmployees =
	new XElement("Employees",
		new XElement("Employee",
			new XAttribute("type", "Programmer"),
			new XElement("FirstName", "Alex"),
			new XElement("LastName", "Erohin")),
		new XElement("Employee",
			new XAttribute("type", "Editor"),
			new XElement("FirstName", "Elena"),
			new XElement("LastName", "Volkova")));

Console.WriteLine(xEmployees);
xEmployees.Dump();
xEmployees.Save(@"C:\Users\MIB\Desktop\employees1.xml");