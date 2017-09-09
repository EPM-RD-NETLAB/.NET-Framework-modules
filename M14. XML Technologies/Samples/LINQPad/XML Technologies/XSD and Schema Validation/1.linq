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

// Перед чтением и обработкой файл или документ XML можно провериь на  
// предмет сооьветствия одной или нескльким схемам, для того, чтобы:
//	• уменьшить количество проверок на ошибки и обработок исключений.
//	• обнаружиь ошибки, котрые могли остаться не замеченными.
//	• сообщения об ошибках являются более подробными.
// Для проверки достоверности необходимо подключить схему к XmlReader,
// XmlDocument, или X-DOM объекту,
// затем читать или загружать XML обячным способом.
// проверка достоверности происходит автоматически (дважды чиать не нужно!) 


//Validating with an XmlReader
XmlReaderSettings settings = new XmlReaderSettings();
settings.ValidationType = ValidationType.Schema;
string path = @"C:\Users\MIB\Desktop\";
settings.Schemas.Add (null, path + "customers.xsd");

using (XmlReader r = XmlReader.Create (path + "customersValid.xml", settings))
{
	try 
	{ 
		while (r.Read());//Calling Read on its own validates both elements and attributes: you don’t need to navigate to each individual attribute for it to be validated 
		"Valid!".Dump();
	}
	catch (XmlSchemaValidationException ex)
	{
    	ex.Dump();
	}
}

using (XmlReader r = XmlReader.Create (path + "CustomersInvalid.xml", settings))
{
	try 
	{ 
		while (r.Read());//Calling Read on its own validates both elements and attributes: you don’t need to navigate to each individual attribute for it to be validated 
		"Valid!".Dump();
	}
	catch (XmlSchemaValidationException ex)
	{
    	ex.Dump();
	}
}