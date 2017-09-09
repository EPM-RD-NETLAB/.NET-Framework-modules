<Query Kind="Statements">
  <Namespace>System.Xml.Xsl</Namespace>
</Query>

//Для XML можно выполнять трансформации XML, используя для этого
//два совершенно разных подхода.
//Первый подход заключается в применении языка XSLT 
//(extensible Stylesheet Language Transformations) через классы-мосты 
//— XmlReader и XmlWriter. 

//Второй подход предусматривает использование для трансформаций самого 
//API-интерфейса LINQ to XML за счет функционального конструирования 
//целевого документа XML и встраивания запроса LINQ to XML в некоторый 
//документ XML.

//Применение XSLT 
//— стандартная технология XML. Существует инструментарий, который помогает
//в написании, отладке и тестировании трансформаций XSLT
// - cуществует множество доступных XSLT-документов, из которых можно 
//выбрать нужные
// - использование XSLT для трансформаций наиболее динамично. 
//В отличие от применения подхода на основе функционального конструирования
//LINQ to XML, повторно компилировать код для изменения трансформации 
//не понадобится. Простое изменение документа XSLT позволяет модифицировать 
//трансформации во время выполнения.

//указывается XSL-разметка для создания некоторой HTML-разметки
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
xDocument.Dump("Source");
string path = @"C:\Users\MIB\Desktop\";
xDocument.Save(path + "source.xml");
Process.Start(path + "source.xml");
//Необходимо создать новый XDocument для трансформированной версии. 
//Затем из этого документа будет построен XmlWriter 
//(CreateWriter и CreateReader классов XDocument), 
//создан экземпляр объекта XslCompiledTransform, 
//загружен объект трансформации с помощью таблицы стилей трансформации и 
//выполнена трансформация входного XML-документа в выходной XmlWriter

XDocument transformedDoc = new XDocument();
using(XmlWriter writer = transformedDoc.CreateWriter())
{
	XmlReader reader = XmlReader.Create(new StringReader(xsl));
	XslCompiledTransform transform = new XslCompiledTransform();
	transform.Load(reader);
	transform.Transform(xDocument.CreateReader(), writer);//input->result
}

//для выполнения трансформации используются оба класса — XmlWriter и XmlReader
transformedDoc.Dump("Transform");
transformedDoc.Save(path + "transform.htm");
Process.Start(path + "transform.htm");