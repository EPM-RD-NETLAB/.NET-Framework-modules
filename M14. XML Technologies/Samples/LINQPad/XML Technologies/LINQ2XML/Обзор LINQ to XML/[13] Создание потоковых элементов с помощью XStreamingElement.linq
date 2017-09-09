<Query Kind="Statements" />

string[] names = { "John", "Paul", "George", "Pete" };
XElement xNames = new XElement("Beatles",
				from n in names
				select new XElement("Name",n));
//Элемент xNames полностью создан перед изменением элемента массива names
names[3] = "Ringo";
Console.WriteLine(xNames.ToString());
//Если действительно нужно, чтобы конструирование дерева XML было отложено,
//необходим какой-то другой способ, и именно для этого предназначены 
//потоковые (streaming) элементы
XStreamingElement xNamesStr = new XStreamingElement("Beatles",
						from n in names
						select new XElement("Name", n));

names[3] = "Ringo";
Console.WriteLine();
Console.WriteLine(xNamesStr.ToString());