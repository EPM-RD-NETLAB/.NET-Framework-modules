<Query Kind="Statements">
  <Namespace>System.Xml.Schema</Namespace>
</Query>

string path = @"C:\Users\MIB\Desktop\";
XDocument xDocument = XDocument.Load(path + "employees.xml"); 
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