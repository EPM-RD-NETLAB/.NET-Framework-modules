<Query Kind="Statements" />

//Атрибут (атрибуты не наследуются от узлов!) реализованный в LINQ to XML 
//с помощью класса XAttribute, является парой "имя-значение", хранящейся в
//коллекции объектов XAttribute, которые относятся к объекту XElement. 
//Используя функциональное конструирование, можно создать атрибут и "на лету"
//добавить его к элементу

XElement xEmployee = new XElement("Employee",
				new XAttribute("type", "Programmer"));
xEmployee.Dump();

//Иногда не удается создать атрибут одновременно с конструированием 
//его элемента. В таком случае должен быть создан его экземпляр и затем 
//добавлен к элементу

xEmployee = new XElement("Employee");
XAttribute xAttr = new XAttribute("type", "Programmer");

xEmployee.Add(xAttr);
xEmployee.Dump();