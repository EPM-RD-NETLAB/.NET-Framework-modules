<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

var doc = new XmlDocument();
string path = @"C:\Users\MIB\Desktop\";
doc.Load(path + "customers.xml");

XPathNavigator nav = doc.CreateNavigator();//курсор в представлении XPath Data Model
string xPath = "customers/customer/firstname/text()";
XPathNodeIterator iterator = nav.Select(xPath);
//SelectSingleNode create single XPathNavigator
foreach (XPathNavigator cur in iterator)
  Console.WriteLine (cur.Value);
  
XPathNavigator nav1 = doc.CreateNavigator();
XPathExpression expr = nav1.Compile ("customers/customer/firstname");//ускорение XPath
foreach (XPathNavigator a in nav.Select (expr))
  Console.WriteLine (a.Value);