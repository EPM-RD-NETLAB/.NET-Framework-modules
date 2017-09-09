<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main(){ }

public class Person : System.Xml.Serialization.IXmlSerializable
{
    private string personName;

    public Person (string name)
    {
        personName = name;
    }

    public Person ()
    {
        personName = null;
    }

    public void WriteXml (XmlWriter writer)
    {
        writer.WriteString(personName);
    }

    public void ReadXml (XmlReader reader)
    {
        personName = reader.ReadString();
    }

    public System.Xml.Schema.XmlSchema GetSchema()
    {
        return(null);
    }

    public override string ToString()
    {
        return(personName);
    }
}