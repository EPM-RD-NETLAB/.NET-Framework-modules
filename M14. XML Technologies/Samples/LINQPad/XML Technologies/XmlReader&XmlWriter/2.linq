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
string xml = @"<?xml version='1.0' encoding='utf-8' ?>"+
			"<customer id='123' status='archived'>"+
			"<firstname>Jim</firstname>"+
			"<lastname>Bo</lastname>"+
			"<quote><![CDATA[C#'s operators include: < > &]]></quote>"+
			"<!--  That wasn't so bad! -->"+
			"</customer>";
XElement xElement = XElement.Parse(xml);
string path = @"C:\Users\MIB\Desktop\";
xElement.Save(path + "customers.xml");
xElement.Dump();
//-------------------------------------------

//Processing XNodeType:
XmlReaderSettings settings = new XmlReaderSettings();
settings.IgnoreWhitespace = true;

using (XmlReader r = XmlReader.Create (path + "customers.xml", settings))
	while (r.Read())
	{
		//https://msdn.microsoft.com/ru-ru/library/system.xml.xmlnodetype(v=vs.110).aspx
    	Console.Write (r.NodeType.ToString().PadRight (17, '-'));
    	Console.Write ("> ".PadRight (r.Depth * 3));

    	switch (r.NodeType)
    	{
      		case XmlNodeType.Element:
      		case XmlNodeType.EndElement:
        		Console.WriteLine (r.Name);//в зависимости от типа узла наполняется либо Name либо Value
				break;

      	case XmlNodeType.Text:
      	case XmlNodeType.CDATA:
      	case XmlNodeType.Comment:
      	case XmlNodeType.XmlDeclaration:
        	Console.WriteLine (r.Value); 
			break;

      	case XmlNodeType.DocumentType:
        	Console.WriteLine (r.Name + " - " + r.Value); 
			break;

      	default: break;
    }
}