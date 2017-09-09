<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

//общие опрерации XPath
// 		- / дочерние узлы
// 		- // дочерние узлы рекурсивно
// 		- . текущий узел (обычно подразумевается) 
//      - .. родительский узел
// 		- * групповой символ
// 		- @ атрибут
// 		- [] фильтр
// 		- : разделитель пространства имен

var doc = new XmlDocument();
string path = @"C:\Users\MIB\Desktop\";
doc.Load(path + "customers.xml");
doc.Dump();

XmlNode node1 = doc.SelectSingleNode ("customers");
node1.Dump("customers");

XmlNode node2 = doc.SelectSingleNode ("customers/customer");
node2.Dump("customers/customer");

XmlNodeList nodes3 = doc.SelectNodes ("//lastname");
nodes3.Dump("//lastname");

XmlNodeList nodes4 = doc.SelectNodes ("customers/customer/*");//@* select all nodes
nodes4.Dump("customers/customer/*");

XmlNode node5 = doc.SelectSingleNode ("customers/customer/@id");
node5.Dump("customers/customer/@id");

XmlNode node6 = doc.SelectSingleNode ("customers/customer[firstname='Jim']");
node6.Dump("customers/customer[firstname='Jim']");