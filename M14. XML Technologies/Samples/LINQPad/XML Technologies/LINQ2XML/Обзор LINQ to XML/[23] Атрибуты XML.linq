<Query Kind="Statements" />

//Создание и обход атрибутов
//Вперед с помощью XElement.FirstAttribute
// Это используется для сохранения ссылки на один из элементов дерева XML
XElement firstEmployee;

XDocument xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XAttribute("language", "Russian"),
						new XAttribute("age",26),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
firstEmployee.FirstAttribute.Dump("FirstAttribute");

//Вперед с помощью XAttribute.NextAttribute
firstEmployee.FirstAttribute.NextAttribute.Dump("NextAttribute");

//Назад с помощью XAttribute.PreviousAttribute
firstEmployee.FirstAttribute.NextAttribute.PreviousAttribute.Dump("PreviousAttribute");

//Назад с помощью XElement.LastAttribute
firstEmployee.LastAttribute.Dump("XElement.LastAttribute");

//XElement.Attribute()
(firstEmployee.Attribute("language").Value).Dump("XElement.Attribute");

//XElement.Attributes()
xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XAttribute("language", "Russian"),
						new XAttribute("age",26),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
firstEmployee.Attributes().Dump();

//Модификация атрибутов
//Добавление атрибутов...