<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//Creating xml:
//Класс XmlWriter и его наследники предоставляют более 
//«помехоустойчивый» способ генерации XML-документа. 
//В следующем примере применяется класс XmlTextWriter

string path = @"C:\Users\MIB\Desktop\";

var message = "Hello, dude!";
var xw = new XmlTextWriter(path + "greetings.xml", Encoding.UTF8)
             { Formatting = Formatting.Indented, Indentation = 2 };
xw.WriteStartDocument();
xw.WriteStartElement("greeting");
xw.WriteString(message);
xw.WriteEndElement();
xw.WriteEndDocument();
xw.Flush();

XmlWriterSettings settings = new XmlWriterSettings();
settings.Indent = true;


using (XmlWriter writer = XmlWriter.Create (path + "foo.xml", settings))
{
  writer.WriteStartElement ("customer");
  writer.WriteElementString ("firstname", "Jim");
  writer.WriteElementString ("lastname"," Bo");
  writer.WriteEndElement();
}