<Query Kind="Program">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
  <Namespace>System.Xml.Schema</Namespace>
</Query>

//Using ValidationEventHandler

void Main()
{
	XmlReaderSettings settings = new XmlReaderSettings();
	settings.ValidationType = ValidationType.Schema;
	string path = @"C:\Users\MIB\Desktop\";
	settings.Schemas.Add (null, path + "customers.xsd");
	
	settings.ValidationEventHandler += ValidationHandler;
	//получить сведения о всех ошибках в документе
	
	using (XmlReader r = XmlReader.Create (path + "customersInvalid.xml", settings))
	  while (r.Read()) ;
}

static void ValidationHandler (object sender, ValidationEventArgs e)
{
  Console.WriteLine ("Error: {0} in line {1} in position {2}",
  	e.Exception.Message,e.Exception.LineNumber,e.Exception.LinePosition );
}