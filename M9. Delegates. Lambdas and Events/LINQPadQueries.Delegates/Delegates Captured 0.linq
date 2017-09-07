<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Внутренняя реализация замыканий

static Action CreateAction()
{
    int count = 0;
    Action action = delegate
    {
        count++;
        Console.WriteLine("Count = {0}", count);
    };
    return action;
}
void Main()
{
    Action action = CreateAction();
    action();
    action();
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
	//	Assembly.GetExecutingAssembly().Location);
}