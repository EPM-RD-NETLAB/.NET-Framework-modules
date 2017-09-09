<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//Querying with Namespaces

string xmlString = @"<?xml version='1.0' encoding='utf-8'?>
<o:customers xmlns:o='http://oreilly.com'>
  <o:customer id='123' status='archived'>
    <firstname>Jim</firstname>
    <lastname>Bo</lastname>
  </o:customer>
  <o:customer>
    <firstname>Thomas</firstname>
    <lastname>Jefferson</lastname>
  </o:customer>
</o:customers>";

var doc = new XmlDocument();
doc.LoadXml(xmlString);

XmlNamespaceManager xnm = new XmlNamespaceManager(doc.NameTable);
xnm.AddNamespace("o","http://oreilly.com");

XmlNodeList n = doc.SelectNodes ("o:customers/o:customer",xnm);
n.Dump();