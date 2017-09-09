<Query Kind="Statements" />

//"Проблема Хэллоуина" не всегда проявляется одинаково, 
//иногда перечисление может прекратиться раньше, чем должно; 
//иногда оно генерирует исключения – поведение варьируется 
//в зависимости от того, что именно произошло

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
xDocument.Dump();
IEnumerable<XElement> elements =
				xDocument.Element("Employees").Elements("Employee");
elements.Dump();

foreach (XElement x in elements)
	Console.WriteLine("Исходный элемент: {0} : значение = {1}",	x.Name, x.Value);

foreach (XElement x in elements)
{
	Console.WriteLine("Удаление: {0} = {1}", x.Name, x.Value);
	x.Remove();
}
elements.Dump();
//foreach (XElement x in elements)
//{
//	Console.WriteLine("Удаление: {0} = {1}", x.Name, x.Value);
//}

Console.WriteLine("\n" + xDocument);