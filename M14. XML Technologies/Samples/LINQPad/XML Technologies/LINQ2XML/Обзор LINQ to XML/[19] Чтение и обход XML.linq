<Query Kind="Statements" />

//Обход XML выполняется с помощью 4 свойств и 11 методов.

// используется для хранения ссылки на один из элементов в дереве XML.
XElement firstEmployee;

XDocument xDocument = new XDocument(
  	new XDeclaration("1.0", "UTF-8", "yes"),
  	new XDocumentType("Employees", null, "Employees.dtd", null),
  	new XProcessingInstruction("EmployeeCataloger", "out-of-print"),
	// В следующей строке сохраняется ссылка на первый элемент
  	new XElement("Employees", 
		new XComment("Начало списка"),
		firstEmployee = 
		new XElement("Employee",
	  		new XComment("Это программист"),
	  		new XProcessingInstruction("ProgrammerHandler", "new"),
	  		new XAttribute("type", "Programmer"),
	  		new XElement("FirstName", 
		  		new XText("Alex"),
		  		new XElement("NickName","alexsave")),
	  		new XElement("LastName", "Erohin")),
		new XElement("Employee",
	  		new XAttribute("type", "Editor"),
	  		new XElement("FirstName", "Elena"),
	  		new XElement("LastName", "Volkova")),
		new XComment("Конец списка")));
			
xDocument.Dump("XML-document");

#region Свойства обхода
firstEmployee.Dump("firstEmployee");
//XNode.NextNode
firstEmployee.NextNode.Dump("firstEmployee.NextNode");
//XNode.PreviousNode
firstEmployee.NextNode.PreviousNode.Dump("firstEmployee.NextNode.PreviousNode");
// XObject.Document
firstEmployee.Document.Dump("Document");
//XObject.Parent
firstEmployee.Parent.Dump("Parent");
#endregion

#region Методы обхода
//XContainer.Nodes()
firstEmployee.Nodes().Dump("Nodes");
firstEmployee.Nodes().OfType<XElement>().Dump("Nodes().OfType<XElement>");
firstEmployee.Nodes().OfType<XComment>().Dump("firstEmployee.Nodes().OfType<XComment>");
//А можно ли с помощью операции OfТуpe извлечь только атрибуты? 
//Нет, нельзя. В отличие от W3C XML DOM API,
//в LINQ to XML атрибуты не являются узлами дерева XML.
//Они представляют собой последовательность пар "имя-значение",
//привязанных к элементу. Чтобы получить атрибуты узла Employee,
//придется изменить код, как показано ниже:
//XContainer.Attributes()
firstEmployee.Attributes().Dump("firstEmployee.Attributes");
//XContainer.Elements()
firstEmployee.Elements().Dump("firstEmployee.Elements");
firstEmployee.Elements("FirstName").Dump();
firstEmployee	.Element("FirstName")
				.Element("NickName")
				.Ancestors().Dump("Ancestors");//предки

firstEmployee.Descendants().Dump("Descendants");
firstEmployee.DescendantsAndSelf("DescendantsAndSelf").Dump();
//XNode.NodesAfterSelf()
firstEmployee.NodesAfterSelf().Dump("NodesAfterSelf");
//XNode.ElementsAfterSelf()");
firstEmployee.ElementsAfterSelf("ElementsAfterSelf").Dump();
//XNode.NodesBeforeSelf()
firstEmployee.NextNode.NodesBeforeSelf().Dump();
//XNode.ElementsBeforeSelf()
firstEmployee.NextNode.ElementsBeforeSelf().Dump();
#endregion