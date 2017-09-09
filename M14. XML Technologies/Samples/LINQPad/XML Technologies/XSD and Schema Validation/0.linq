<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

string xmlValid = @"<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<customers>
  <customer id='1' status='active'>
    <firstname>Jim</firstname>
    <lastname>Bo</lastname>
  </customer>
  <customer id='2' status='archived'>
    <firstname>Thomas</firstname>
    <lastname>Jefferson</lastname>
  </customer>
</customers>";

string xmlInvalid = @"<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<customers>
  <customer id='1'>
    <firstname>Jim</firstname>
    <lastname>Bo</lastname>
  </customer>
  <customer status='archived'>
    <firstname>Thomas</firstname>
    <lastname>Jefferson</lastname>
  </customer>
</customers>";

string xsd = @"<?xml version='1.0' encoding='utf-8'?>
<xs:schema attributeFormDefault='unqualified'
           elementFormDefault='qualified'
           xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='customers'>
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs='unbounded' name='customer'>
          <xs:complexType>
            <xs:sequence>
              <xs:element name='firstname' type='xs:string' />
              <xs:element name='lastname' type='xs:string' />
            </xs:sequence>
            <xs:attribute name='id' type='xs:int' use='required' />
            <xs:attribute name='status' type='xs:string' use='required' />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
string path = @"C:\Users\MIB\Desktop\";

var doc = new XmlDocument();

doc.LoadXml(xmlValid);
doc.Save(path + "customersValid.xml");

doc.LoadXml(xmlInvalid);
doc.Save(path + "customersInvalid.xml");

doc.LoadXml(xsd);
doc.Save(path + "customers.xsd");