<Query Kind="Statements" />

//XElement.Value на объектах XElement, XText.Value на объектах XText 
//и XComment.Value на объектах XComment

// используется для сохранения ссылки на один из элементов дерева XML
XElement firstEmployee;
XDocument xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XComment("Some comment"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
xDoc.Dump("Перед обновлением узлов: ");

// Теперь обновим элемент, комментарий и текстовый узел
firstEmployee.Element("FirstName").Value = "Alexandr";
firstEmployee.Nodes().OfType<XComment>().Single().Value = "Это программист :)";
((XElement)firstEmployee.Element("FirstName").NextNode)
	.Nodes().OfType<XText>().Single().Value = "Mr. Erohin";

xDoc.Dump("После обновления узлов:");

//XElement.ReplaceAll()

xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XComment("Some comment"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
firstEmployee.ReplaceAll(
		new XElement("FirstName", "Dmitry"),
		new XElement("LastName", "Morozec"));
xDoc.Dump("После обновления узлов:");

//Метод XElement.SetElementValue() -обладает способностью добавлять, изменять и удалять элементы
xDoc = new XDocument(
				new XElement("Employees", firstEmployee =
					new XElement("Employee",
						new XAttribute("type", "Programmer"),
						new XComment("Some comment"),
						new XElement("FirstName", "Alex"),
						new XElement("LastName", "Erohin"))));
// Обновление
firstEmployee.SetElementValue("FirstName", "Alexandr");

// Добавление элементов
firstEmployee.SetElementValue("Age", "26");

// Удаление элемента
firstEmployee.SetElementValue("LastName", null);
xDoc.Dump("После обновления узлов:");