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
doc.AppendChild (doc.CreateXmlDeclaration ("1.0", null, "yes"));

XmlAttribute id     = doc.CreateAttribute ("id");
XmlAttribute status = doc.CreateAttribute ("status");
id.Value     = "123";
status.Value = "archived";

XmlElement firstname = doc.CreateElement ("firstname");
XmlElement lastname  = doc.CreateElement ("lastname");
firstname.AppendChild (doc.CreateTextNode ("Jim"));
lastname.AppendChild  (doc.CreateTextNode ("Bo"));

XmlElement customer = doc.CreateElement ("customer");
customer.Attributes.Append (id);
customer.Attributes.Append (status);
customer.AppendChild (lastname);
customer.AppendChild (firstname);

doc.AppendChild (customer);
doc.Save(@"C:\Users\MIB\Desktop\1.xml");