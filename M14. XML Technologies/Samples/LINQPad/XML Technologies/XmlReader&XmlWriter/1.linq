<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//help region
string xml = @"<?xml version='1.0' encoding='utf-8' standalone='yes'?>" +
			"<customer id='123' status='archived'>" +
			"<firstname>Jim</firstname>" +
			"<lastname>Bo</lastname>" +
			"</customer>";
XElement xElement = XElement.Parse(xml);
string path = @"C:\Users\MIB\Desktop\";
xElement.Save(path + "customers.xml");
xElement.Dump();
//-------------------------------------------
//https://msdn.microsoft.com/ru-ru/library/system.xml.xmlreader%28v=vs.110%29.aspx

//Enumerating nodes with XmlReader:
XmlReaderSettings settings = new XmlReaderSettings();
settings.IgnoreWhitespace = true;

//using (XmlReader reader = XmlReader.Create (path + "customers.xml", settings))
using (XmlReader reader = new XmlTextReader(path + "customers.xml"))
{
	while (reader.Read())//При переопределении в производном классе считывает из потока следующий узел
	{
	   	Console.WriteLine (reader.NodeType);
		//При переопределении в производном классе получает тип текущего узла.
	}
}