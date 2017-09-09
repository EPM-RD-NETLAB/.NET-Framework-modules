<Query Kind="Statements" />

var xDoc = new XDocument(
		  new XDeclaration("1.0", "utf-8", null),
		  new XComment("Created: " + DateTime.Now.ToString()),
		  new XElement("DvdList",
			  new XElement("DVD",
				  new XAttribute("ID", "1"),
				  new XAttribute("Category", "Science Fiction"),
				  new XElement("Title", "The Matrix"),
				  new XElement("Director", "Larry Wachowski"),
				  new XElement("Price", "18.74"),
				  new XElement("Starring",
					  new XElement("Star", "Keanu Reeves"),
					  new XElement("Star", "Laurence Fishburne")
				  )
			  )));
xDoc.Dump();
string path = @"C:\Users\MIB\Desktop\";
xDoc.Save(path + "temp.xml");
//Process.Start(path + "temp.xml");