<Query Kind="Statements" />

//С использованием функционального конструирования можно создать 
//комментарий и добавить его к элементу "на лету"

XElement xEmployee = new XElement("Employee",
				new XComment("Добавление нового сотрудника"));
xEmployee.Dump();



xEmployee = new XElement("Employee");
XComment xCom = new XComment("Добавление нового сотрудника");

xEmployee.Add(xCom);
xEmployee.Dump();