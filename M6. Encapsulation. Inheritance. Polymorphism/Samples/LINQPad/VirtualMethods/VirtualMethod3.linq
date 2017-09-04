<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	BaseClass obj = new DerivedClass();
	obj.InstanceVirtualBaseClassMethod();
	Process.Start (@"C:\Users\MIB\Desktop\ildasm.exe",Assembly.GetExecutingAssembly().Location);
}

public class BaseClass
{
	public void InstanceBaseClassMethod(){ }
    public virtual void InstanceVirtualBaseClassMethod() {"Base class virtual method works".Dump(); }
	public static void StaticBaseClassMethod() { }
}
public class DerivedClass : BaseClass
{
    public override void InstanceVirtualBaseClassMethod() {"Derived class virtual method works".Dump();}
}

public class AnotherDerivedClass : BaseClass
{
    public new virtual void InstanceVirtualBaseClassMethod() {"Derived class virtual method works".Dump();}
}

