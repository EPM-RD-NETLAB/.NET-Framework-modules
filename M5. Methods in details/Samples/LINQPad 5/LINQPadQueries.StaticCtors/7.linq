<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

class Test
{
	static object _obj;
}

static void Main()
{
	Test t = new Test();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}