<Query Kind="Statements" />

//Инструкции обработки никогда ранее не было так легко создавать, 
//как в API-интерфейсе LINQ to XML. Здесь они реализуются классом 
//XProcessingInstruction.
//Инструкции обработки можно создавать на уровне документа или элемента,
//создавая их "на лету" в обоих случаях с помощью функционального конструирования

XDocument xDoc = new XDocument(
		new XProcessingInstruction("EployeCataloger", "out-of-print"),
		new XElement("Employees",
			new XElement("Employee",
				new XProcessingInstruction("EmployeeDeleter", "delete"),
				new XElement("FirstName", "Alex"),
				new XElement("LastName", "Erohin"))));
xDoc.Dump();