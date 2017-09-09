<Query Kind="Statements" />

//API-интерфейс LINQ to XML делает операцию создания типов документов 
//совершенно безболезненной. Типы XML-документов реализованы LINQ to XML
//с помощью класса XDocumentType

//В отличие от большинства других классов в LINQ to XML, типы документов 
//предназначены для добавления к XML-документам, а не к элементам

XDocument xDoc = new XDocument(new XDocumentType("Employees", null, 
	"Employees.dtd", null),new XElement("Employee"));
xDoc.Dump();

xDoc = new XDocument();
XDocumentType docType = new XDocumentType("Employees", null, 
							"Employees.dtd", null);

xDoc.Add(docType, new XElement("Employee"));
xDoc.Dump();
//Если добавить тип документа после добавления любого элемента, 
//сгенерируется исключение
