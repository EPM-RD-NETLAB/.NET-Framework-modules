<Query Kind="Statements" />

//2-ый подход 
//Хотя LINQ to XML поддерживает трансформацию XSLT,
//существуют очень эффективные способы выполнения трансформаций 
//на основе самого API-интерфейса LINQ to XML
XDocument xDocument = new XDocument(
			  new XElement("Employees",
					 new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin")),
					 new XElement("Employee",
					   new XAttribute("type", "Editor"),
					   new XElement("FirstName", "Elena"),
					   new XElement("LastName", "Volkova"))));

xDocument.Dump("Исходный XML-документ:");

XDocument xTransDocument = new XDocument(
			   new XElement("MediaEmployees",
				   new XAttribute("type", "work"),
				   xDocument.Element("Employees").Elements("Employee")
							.Select(e => new XElement("Employee",
								new XAttribute("Role", (string)e.Attribute("type")),
								new XAttribute("Name", (string)e.Element("FirstName") + " " +
									(string)e.Element("LastName"))))));

xTransDocument.Dump("Трансформированный документ:");