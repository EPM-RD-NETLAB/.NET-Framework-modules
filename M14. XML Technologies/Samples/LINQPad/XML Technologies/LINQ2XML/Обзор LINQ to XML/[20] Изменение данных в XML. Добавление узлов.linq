<Query Kind="Statements" />

//Добавление узлов
XDocument xDoc = new XDocument(
				new XElement("Employees",
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
xDoc.Dump("document");
//method XContainer.Add() (AddLast)
xDoc.Element("Employees").Add(
			new XElement("Employee",
						new XAttribute("type", "Editor"),
						new XElement("FirstName", "Elena"),
						new XElement("LastName", "Volkova")));
xDoc.Dump("document Add");
//method XContainer.AddFirst()
xDoc.Element("Employees").AddFirst(
					new XElement("Employee",
						new XAttribute("type", "Editor"),
						new XElement("FirstName", "Olga"),
						new XElement("LastName", "Ivanova")));
xDoc.Dump("document AddFirst");
//methods XNode.AddBeforeSelf() и XNode.AddAfterSelf
xDoc.Element("Employees")
				.Elements("Employee")
				.Where(e => ((string)e.Element("FirstName")) == "Elena")
				.Single<XElement>()
				.AddBeforeSelf(
				   new XElement("Employee",
					   new XAttribute("type", "Technical Reviewer"),
					   new XElement("FirstName", "Dmitry"),
					   new XElement("LastName", "Morozec")));
xDoc.Dump("document XNode.AddBeforeSelf");

xDoc.Element("Employees")
				.Element("Employee")
				.AddAfterSelf(
				   new XElement("Employee",
					   new XAttribute("type", "Technical Reviewer"),
					   new XElement("FirstName", "Dmitry"),
					   new XElement("LastName", "Morozec")));
xDoc.Dump("document XNode.AddAfterSelf");