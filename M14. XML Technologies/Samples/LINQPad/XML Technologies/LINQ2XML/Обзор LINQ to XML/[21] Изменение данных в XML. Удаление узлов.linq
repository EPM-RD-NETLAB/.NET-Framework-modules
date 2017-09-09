<Query Kind="Statements" />

//method XNode.Remove()
// Используется для сохранения ссылки на один из элементов дерева XML
XElement firstEmployee;

XDocument xDoc = new XDocument(
				new XElement("Employees", 
				firstEmployee = new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin")),
					new XElement("Employee",
						new XAttribute("type", "Editor"),
						new XElement("FirstName", "Elena"),
						new XElement("LastName", "Volkova"))));
xDoc.Dump("Перед удалением узла: ");
firstEmployee.Remove();
xDoc.Dump("После удаления узла: ");

//method IEnumerable<T>.Remove()
xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin")),
					new XElement("Employee",
						new XAttribute("type", "Editor"),
						new XElement("FirstName", "Elena"),
						new XElement("LastName", "Volkova"))));

xDoc.Descendants().Where(e => e.Name == "FirstName").Remove();
xDoc.Dump("После удаления узла c FirstName");

//method XElement.RemoveAll() - удалить содержимое элемента, но не сам элемент
xDoc = new XDocument(
				new XElement("Employees",
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin")),
					new XElement("Employee",
						new XAttribute("type", "Editor"),
						new XElement("FirstName", "Elena"),
						new XElement("LastName", "Volkova"))));
xDoc.Element("Employees").RemoveAll();
xDoc.Dump("После удаления узла: ");