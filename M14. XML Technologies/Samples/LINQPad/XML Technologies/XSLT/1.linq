<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

string xsl =
		@"<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
		  <xsl:template match='//Employees'>
			  <html>
				  <body>
				  <h1>Employees</h1>
				  <table>
					  <tr align='left'>
						  <th>Role</th>
						  <th>First Name</th>
						  <th>Last Name</th>
					  </tr>
					  <xsl:apply-templates></xsl:apply-templates>
				  </table>
				  </body>
			  </html>
		  </xsl:template>
		  <xsl:template match='Employee'>
			  <tr>
				  <td><xsl:value-of select='@type'/></td>
				  <td><xsl:value-of select='FirstName'/></td>
				  <td><xsl:value-of select='LastName'/></td>
			  </tr>
		  </xsl:template>
		</xsl:stylesheet>";
string path = @"C:\Users\MIB\Desktop\";
var sc = new XmlDocument();
sc.LoadXml(xsl);
sc.Save(path + "scheme.xslt");

XDocument xDocument = new XDocument(
			  new XElement("Employees",
					 new XElement("Employee",
					   new XAttribute("type", "Programmer"),
					   new XElement("FirstName", "Alex"),
					   new XElement("LastName", "Erohin")),
					 new XElement("Employee",
					   new XAttribute("type", "Editor"),
					   new XElement("FirstName", "Elena"),
					   new XElement("LastName", "Volkova"))));

xDocument.Save(path + "input.xml");

var transform = new System.Xml.Xsl.XslCompiledTransform();
transform.Load (path + "scheme.xslt");
transform.Transform (path + "input.xml",path + "output.htm");//можно передавать XmlWriter, управляя форматированием 
Process.Start(path + "input.xml");
Process.Start(path + "output.htm");
