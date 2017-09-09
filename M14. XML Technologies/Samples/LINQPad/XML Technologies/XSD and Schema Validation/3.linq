<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
  <Namespace>System.Xml.Schema</Namespace>
</Query>

//Validating an X-DOM or XmlDocument
XmlReaderSettings settings = new XmlReaderSettings();
settings.ValidationType = ValidationType.Schema;
settings.Schemas.Add (null, "customers.xsd");

XDocument doc;
using (XmlReader r = XmlReader.Create ("customers.xml", settings))
{
	try 
	{ 
		doc = XDocument.Load (r); 
		"Valid!".Dump();
	}
  	catch (XmlSchemaValidationException ex) 
	{
		ex.Dump();
	}
}

XmlDocument xmlDoc = new XmlDocument();
using (XmlReader r = XmlReader.Create ("customersInvalid.xml", settings))
{
	try 
	{ 
		xmlDoc.Load (r); 
		"Valid!".Dump();
	}
  	catch (XmlSchemaValidationException ex) 
	{
		ex.Dump();
	}
}