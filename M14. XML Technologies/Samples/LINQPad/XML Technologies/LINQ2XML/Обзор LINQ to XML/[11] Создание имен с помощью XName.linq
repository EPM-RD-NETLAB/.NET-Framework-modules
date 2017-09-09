<Query Kind="Statements" />

//В LINQ to XML нет необходимости непосредственно создавать имена с объектами XName. 
//Фактически класс XName не имеет общедоступных конструкторов, так что нет 
//способа создавать его экземпляры. Объект XName может быть создан из строки 
//с необязательным пространством имен автоматически при создании объекта XName

//Объект XName состоит из LocalName — строки — и пространства имен, которое 
//представлено в XNamespace
XNamespace ns = "http://www.bsu.by/training EPAM/ASP.NET/LINQ2XML";
XElement xEmps = new XElement(ns + "Employee");
xEmps.Dump();