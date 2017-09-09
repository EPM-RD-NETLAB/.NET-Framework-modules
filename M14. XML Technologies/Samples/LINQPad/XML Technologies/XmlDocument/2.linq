<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//Creating an XmlDocument:

XmlDocument doc = new XmlDocument();
doc.Load(@"C:\Users\MIB\Desktop\1.xml");//принимает имя файла, Stream, TextWriter, XmlWriter
//LoadXml
doc.Save(@"C:\Users\MIB\Desktop\2.xml");
doc.Dump();

doc.DocumentElement.Dump();
doc.DocumentElement.LastChild.Dump();
doc.DocumentElement.FirstChild.Dump();
doc.DocumentElement.ChildNodes[0].Dump();
doc.DocumentElement.ChildNodes[0].InnerText.Dump();
doc.DocumentElement.ChildNodes[1].InnerText.Dump();
//FirstChild
//LastChild
//NextSibling
//PreviousSibling