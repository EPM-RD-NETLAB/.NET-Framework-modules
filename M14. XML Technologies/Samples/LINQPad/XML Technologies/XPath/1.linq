<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//create customer.xml
{
string xmlString = @"<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<customers>
  <customer id='1' status='active'>
    <firstname>Jim</firstname>
    <lastname>Bo</lastname>
  </customer>
  <customer id='2' status='archived'>
    <firstname>Thomas</firstname>
    <lastname>Jefferson</lastname>
  </customer>
</customers>";
var xmldoc = new XmlDocument();
xmldoc.LoadXml(xmlString);
xmldoc.Save(@"C:\Users\MIB\Desktop\customers.xml");
}
//-------------------------------

//Записать запрос XPath внутри кода можно

//1. вызвать один из методов SelectXXX на XmlDocument или XmlNode
//2. породить XPathNavigator от XmlDocument XPathDocument
//3. вызвать метод расширения XPathXXX на XNode

var doc = new XmlDocument();
string path = @"C:\Users\MIB\Desktop\";
doc.Load(path + "customers.xml");

//Методы SelectXXX принисают строку запроса XPath
XmlNode n = doc.SelectSingleNode ("customers/customer[firstname='Jim']");
n.Dump();
Console.WriteLine (n.InnerXml);
Console.WriteLine (n.InnerText);
"___________".Dump();
//Методы SelectXXX делегируют свою реализацию классу XPathNavigator, 
//который также можно использовать через XmlDocument
//или XPathDocument
XPathNavigator navigator = doc.CreateNavigator();
var node = navigator.SelectSingleNode("customers/customer[firstname='Jim']");//
node.Dump();
node.Value.Dump();
"___________".Dump();
//Можно выполнять запросы XPath посредством X-DOM, с помощью 
//метода расширения в System.Xml.XPath:
XDocument docXml = XDocument.Load(path + "customers.xml");
XElement element = docXml.XPathSelectElement ("customers/customer[firstname='Jim']");
element.Dump();
Console.WriteLine (element.Value);  // JimBo