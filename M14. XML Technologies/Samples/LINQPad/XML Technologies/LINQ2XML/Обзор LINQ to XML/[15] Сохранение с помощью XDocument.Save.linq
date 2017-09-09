<Query Kind="Statements" />

//Сохранять XML-документ можно с использованием любого из 
//нескольких методов XDocument.Save
//
//void XDocument.Save(string filename);
//void XDocument.Save(TextWriter textWriter);
//void XDocument.Save(XmlWriter writer);
//void XDocument.Save(string filename, SaveOptions options);
//void XDocument.Save(TextWriter textWriter, SaveOptions options);

XDocument xDoc = new XDocument(
			   new XElement("Employees",
				   new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					   new XAttribute("language", "Russian"),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin"))));
string path = @"C:\Users\MIB\Desktop\";
xDoc.Save(path + "employees.xml");
xDoc.Save(path + "employees1.xml", SaveOptions.DisableFormatting);