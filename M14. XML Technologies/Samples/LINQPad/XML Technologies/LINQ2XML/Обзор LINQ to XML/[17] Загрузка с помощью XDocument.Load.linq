<Query Kind="Statements" />

//LoadOptions.None
//Применяйте эту опцию, чтобы указать, что никакие опции загрузки не используются.
//
//LoadOptions.PreserveWhitespace
//Используйте эту опцию, чтобы предохранить пробелы и пустые строки в исходном XML
//
//LoadOptions.SetLineInfo
//Применяйте эту опцию, чтобы иметь возможность получать строку и позицию любого 
//объекта, унаследованного от XObject, посредством интерфейса IXmlLineInfo
//
//LoadOptions.SetBaseUri
//Используйте эту опцию, чтобы получать базовый URI любого объекта-наследника XObject
string path = @"C:\Users\MIB\Desktop\";

XDocument xDoc = XDocument.Load(path + "employees.xml",
				LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);//

Console.WriteLine(xDoc);

XElement firstName = xDoc.Descendants("FirstName").First();

Console.WriteLine("firstName Строка {0} - Позиция {1}",
				((IXmlLineInfo)firstName).LineNumber,
				((IXmlLineInfo)firstName).LinePosition);

Console.WriteLine("Базовый URI: {0}", firstName.BaseUri);