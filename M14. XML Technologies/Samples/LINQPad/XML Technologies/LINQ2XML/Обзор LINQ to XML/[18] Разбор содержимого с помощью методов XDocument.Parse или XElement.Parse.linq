<Query Kind="Statements" />

//Оба класса — и XDocument, и XElement — имеют статический метод Parse для 
//разбора строк XML. 

XDocument xDoc = new XDocument(
			   new XElement("Employees",
				   new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					   new XAttribute("language", "Russian"),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin"))));

//xDoc.Save("employees.xml",SaveOptions.DisableFormatting);
//string xml = XDocument.Load("employees.xml").ToString();
//xml.Dump();
string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Employees><Employee type=\"Programmer\" language=\"Russian\"><FirstName>Alex</FirstName><LastName>Erohin</LastName></Employee></Employees>";

XElement xElement = XElement.Parse(xml);
xElement.Dump();