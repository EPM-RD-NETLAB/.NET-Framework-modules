<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	var baseObj = new BaseClass();
	baseObj.InstanceBaseClassMethod();
	baseObj.VirtualBaseClassMethod();
	BaseClass.StaticBaseClassMethod();
	
	var derObj = new DerivedClass();
	DerivedClass.StaticBaseClassMethod();
	baseObj = derObj;
	baseObj.InstanceBaseClassMethod();
	baseObj.VirtualBaseClassMethod();
	//value types!
	int x = 12;
	x.ToString();
	object o = x;
	o.ToString();
}

class BaseClass
{
	public void InstanceBaseClassMethod(){"InstanceBaseClassMethod".Dump();}
	public static void StaticBaseClassMethod(){"StaticBaseClassMethod".Dump();}
	public virtual void VirtualBaseClassMethod(){"VirtualBaseClassMethod".Dump();}
}

class DerivedClass : BaseClass
{
	public override void VirtualBaseClassMethod(){"VirtualBaseClassMethod derived".Dump();}
}