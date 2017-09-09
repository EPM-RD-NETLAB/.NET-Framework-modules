<Query Kind="Statements" />

//В LINQ to XML создавать XML-документ
//не обязательно. Также не обязательно это делать для сохранения XML-файла.
//Класс XElement также имеет несколько методов Save,
//предназначенных для этой цели

XElement xElement = new XElement("Employees",
					new XElement("Employee",
						new XAttribute("type","Programmer"),
						new XAttribute("language","Russian"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin")));
string path = @"C:\Users\MIB\Desktop\";
xElement.Save(path + "employees.xml", SaveOptions.None);//SaveOptions.DisableFormatting