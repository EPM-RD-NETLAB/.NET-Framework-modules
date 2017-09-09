<Query Kind="Statements" />

//В отличие от большинства других классов LINQ to XML, объявления должны 
//добавляться к XML-документу, а не к элементу

XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"),
				new XElement("Employee"));
xDoc.Dump();

xDoc = new XDocument(new XElement("Employee"));
XDeclaration xDeclaration = new XDeclaration("1.0", "UTF-8", "no");

xDoc.Declaration = xDeclaration;
xDoc.Dump();
string path = @"C:\Users\MIB\Desktop\";
xDoc.Save(path + "employees.xml");
Process.Start(path + "employees.xml");