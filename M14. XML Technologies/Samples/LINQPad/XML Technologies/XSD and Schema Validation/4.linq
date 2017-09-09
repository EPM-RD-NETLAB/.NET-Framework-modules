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
XDocument doc = XDocument.Load (@"CustomersNoValid.xml");
XmlSchemaSet set = new XmlSchemaSet();
set.Add (null, @"customers.xsd");
StringBuilder errors = new StringBuilder();
doc.Validate (set, (sender, args) => { errors.AppendLine
                                       (args.Exception.Message); }
             );
Console.WriteLine (errors.ToString());