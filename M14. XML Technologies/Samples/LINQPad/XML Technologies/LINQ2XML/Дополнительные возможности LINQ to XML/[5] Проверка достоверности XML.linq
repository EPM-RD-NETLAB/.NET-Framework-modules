<Query Kind="Statements">
  <Namespace>System.Xml.Schema</Namespace>
</Query>

//В LINQ to XML имеются средства проверки XML-документа на соответствие схеме XML.
//Потребность в проверке достоверности в LINQ to XML реализуется за счет 
//статического класса System.Xml.Schema.Extensions, содержащего методы проверки 
//достоверности. Эти методы проверки достоверности реализованы в виде расширяющих
//методов класса Extensions(System.Xml.Schema).
//void Extensions.Validate (this XDocument source, XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler)
//
//void Extensions.Validate (this XDocument source, XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler, bool addSchemaInfo)
//		 
//void Extensions.Validate(this XElement source, 
//		 XmlSchemaObject partialValidationType, XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler)
//
//void Extensions.Validate(this XElement source, 
//		 XmlSchemaObject partialValidationType, XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler, bool addSchemaInfo)
//
//void Extensions.Validate(this XAttribute source, 
//		 XmlSchemaObject partialValidationType,
//		 XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler)
//
//void Extensions.Validate(this XAttribute source, 
//		 XmlSchemaObject partialValidationType, XmlSchemaSet schemas, 
//		 ValidationEventHandler validationEventHandler, bool addSchemaInfo)

XDocument xDocument = new XDocument(
			  new XElement("Employees",
					 new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					    //new XElement("Age",26),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin")),
					 new XElement("Employee",
					   new XAttribute("type", "Editor"),
					   new XElement("FirstName", "Elena"),
					   new XElement("LastName", "Volkova"))));
string path = @"C:\Users\MIB\Desktop\";
xDocument.Dump("Исходный XML-документ: \n");
xDocument.Save(path + "employees.xml");

XmlSchemaInference infer = new XmlSchemaInference();
XmlSchemaSet schemaSet = infer.InferSchema(new XmlTextReader(path + "employees.xml"));

XmlWriter w = XmlWriter.Create(path + "employees.xsd");
foreach (XmlSchema schema in schemaSet.Schemas())
{
	schema.Write(w);
}
w.Close();