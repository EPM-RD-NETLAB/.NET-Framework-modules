<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

class Test
{
	public static string x = EchoAndReturn ("In type initializer");
	public static int t = 34;
	public static string EchoAndReturn (string s)
	{
		Console.WriteLine (s);
		return s;
	}
	
	//static Test(){ }
}

static void Main()
{
	Console.WriteLine("Starting Main");
	// Invoke a static method on Test
	Test.EchoAndReturn("Echo!");
	Console.WriteLine("After echo");
	// Reference a static field in Test
	string y = Test.x;
	// Use the value just to avoid compiler cleverness
	if (y != null)
	{
		Console.WriteLine("After field access");
	}
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}

//Результаты выполнения весьма разнообразны. 
//Среда выполнения может принять решение о запуске
//инициализатора типа по загрузке сборки, чтобы начать с

//In type initializer
//Starting Main
//Echo!
//After echo
//After field access

//Или, возможно, он будет работать, при первом запуске статического метода  ...
//Starting Main
//In type initializer
//Echo!
//After echo
//After field access

//Или даже ждать первого обращения к полю ...
//Starting Main
//Echo!
//After echo
//In type initializer
//After field access