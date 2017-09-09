<Query Kind="Statements" />

//Документы XML реализованы в LINQ to XML в виде класса XDocument

XDocument xDocument = new XDocument(); 
xDocument.Dump("document");
xDocument = new XDocument(
				new XDeclaration("1.0", "UTF-8", "yes"),
				new XDocumentType("Employees", null, "Employees.dtd", null),
				new XProcessingInstruction("EmployeeCataloger", "out-of-print"),
				new XElement("Employees"));
xDocument.Dump("document");
string path = @"C:\Users\MIB\Desktop\";
xDocument.Save(path + "employees.xml");
Process.Start(path + "employees.xml");