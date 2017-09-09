<Query Kind="Statements" />

//Решение в данном случае заключается в кэшировании элементов 
//и выполнении перечисления по кэшу вместо обычной техники перечисления, 
//которая полагается на внутренние указатели, повреждаемые в процессе 
//удаления или модификации элементов

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

foreach (XElement x in elements)
	Console.WriteLine("Исходный элемент: {0} : значение = {1}",	x.Name, x.Value);

foreach (XElement x in elements.ToArray())
{
		 Console.WriteLine("Удаление: {0} = {1}", x.Name, x.Value);
		 x.Remove();
}

elements.Dump();

Console.WriteLine("\n" + xDocument);