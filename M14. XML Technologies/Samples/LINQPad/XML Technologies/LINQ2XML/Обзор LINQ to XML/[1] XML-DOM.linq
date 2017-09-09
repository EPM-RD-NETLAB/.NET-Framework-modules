<Query Kind="Statements" />

// Используем старый API-интерфейс XML DOM
//В этом API-интерфейсе не предусмотрена поддержка создания элемента 
//или любого типа узла в определенном месте дерева XML по отношению 
//к его родителю и его инициализации за одну операцию!

// Объявить некоторые переменные, которые будут использоваться повторно.
XmlElement xmlEmployee;//Employee
XmlAttribute xmlEmployeeType; //EmployeeType
XmlElement xmlFirstName;
XmlElement xmlLastName;

// Необходимо построить документ XML.
XmlDocument xmlDoc = new XmlDocument();

// Создать корневой элемент и добавить его в документ.
XmlElement xmlEmployees = xmlDoc.CreateElement("Employees");
xmlDoc.AppendChild(xmlEmployees);

// Создать список участников
xmlEmployee = xmlDoc.CreateElement("Employee");
xmlEmployeeType = xmlDoc.CreateAttribute("type");
xmlEmployeeType.InnerText = "Programmer";
xmlEmployee.Attributes.Append(xmlEmployeeType);
xmlFirstName = xmlDoc.CreateElement("FirstName");
xmlFirstName.InnerText = "Alex";
xmlEmployee.AppendChild(xmlFirstName);
xmlLastName = xmlDoc.CreateElement("LastName");
xmlLastName.InnerText = "Erohin";
xmlEmployee.AppendChild(xmlLastName);
xmlEmployees.AppendChild(xmlEmployee);

// Создать еще одного участника
xmlEmployee = xmlDoc.CreateElement("Employee");
xmlEmployeeType = xmlDoc.CreateAttribute("type");
xmlEmployeeType.InnerText = "Editor";
xmlEmployee.Attributes.Append(xmlEmployeeType);
xmlFirstName = xmlDoc.CreateElement("FirstName");
xmlFirstName.InnerText = "Elena";
xmlEmployee.AppendChild(xmlFirstName);
xmlLastName = xmlDoc.CreateElement("LastName");
xmlLastName.InnerText = "Volkova";
xmlEmployee.AppendChild(xmlLastName);
xmlEmployees.AppendChild(xmlEmployee);
// Вывод на консоль
xmlDoc.Save(Console.Out);
xmlDoc.Save(@"C:\Users\MIB\Desktop\employees.xml");