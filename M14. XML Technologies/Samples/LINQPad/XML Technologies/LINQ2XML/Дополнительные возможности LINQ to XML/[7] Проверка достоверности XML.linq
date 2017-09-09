<Query Kind="Statements">
  <Namespace>System.Xml.Schema</Namespace>
</Query>

XDocument xDocument = new XDocument(
			  new XElement("Employees",
					 new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					    new XElement("Age",26),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin")),
					 new XElement("Employee",
					   new XAttribute("type", "Editor"),
					   new XElement("FirstName", "Elena"),
					   new XElement("LastName", "Volkova"))));
string path = @"C:\Users\MIB\Desktop\";
xDocument.Dump("Исходный XML-документ: \n");

XDocument newDocument = XDocument.Load(path + "employees.xsd");
newDocument.Dump("Извлеченная схема: \n");

XmlSchemaSet schemaSet = new XmlSchemaSet();
schemaSet.Add(null, path + "employees.xsd");

try
{
	xDocument.Validate(schemaSet, null);
	Console.WriteLine("Проверка достоверности документа завершена успешно");
}
catch (XmlSchemaValidationException ex)
{
	Console.WriteLine("Произошло исключение:   {0}", ex.Message); 
	Console.WriteLine("Документ не прошел проверку достоверности.");
}