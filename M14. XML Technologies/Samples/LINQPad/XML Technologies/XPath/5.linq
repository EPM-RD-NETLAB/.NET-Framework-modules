<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//An XPathNavigator backed by an XPathDocument is faster 
//than an XmlDocument, but it cannot make changes to the
//underlying document

string path = @"C:\Users\MIB\Desktop\";
var pathDoc = new XPathDocument(path + "customers.xml");
XPathNavigator nav = pathDoc.CreateNavigator();
foreach (XPathNavigator a in nav.Select ("customers/customer/firstname"))
  Console.WriteLine (a.Value);