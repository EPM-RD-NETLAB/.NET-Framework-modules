<Query Kind="Statements" />

//Отсутствие иерархического спуска
XDocument xDoc = new XDocument(
			 new XElement("Employees",
			   new XElement("Employee",
				 new XAttribute("type", "Programmer"),
				 new XElement("FirstName", "Alex"), 
				 new XElement("LastName", "Erohin")),
			   new XElement("Employee",
				 new XAttribute("type", "Editor"),
				 new XElement("FirstName", "Elena"), 
				 new XElement("LastName", "Volkova"))));
//извлекаются все элементы-потомки документа по имени Employee
IEnumerable<XElement> elements = xDoc.Descendants("Employee");
elements.Dump("Elements 1");

elements = xDoc.Descendants("Employee")
				.Where(e => ((string)e.Element("FirstName")) == "Elena");
elements.Dump("Elements 2");

elements = from e in xDoc.Descendants("Employee")
			where ((string)e.Attribute("type")) != "Illustrator"
			orderby ((string)e.Element("LastName"))
			select e;
elements.Dump("Elements 3");