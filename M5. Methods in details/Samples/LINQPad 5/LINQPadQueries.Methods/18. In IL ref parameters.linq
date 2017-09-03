<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	int x = 24;
	ChangeIt(ref x);
	Console.WriteLine(x); // will print 42
}

static void ChangeIt(ref int a) 
{
	a = 42; 
}

//IL_0001:  ldc.i4.s    18 //загружает в стек
//IL_0003:  stloc.0     // извлекает из стека верхнее значение и помещает его в локальную переменную x
//IL_0004:  ldloca.s    00 // x // Загружает в стек вычислений адрес локальной переменной с указанным индексом
//IL_0006:  call        UserQuery.ChangeIt
//IL_000B:  nop         
//IL_000C:  ldloc.0     // x
//IL_000D:  call        System.Console.WriteLine
//
//ChangeIt:
//IL_0000:  nop         
//IL_0001:  ldarg.0     //Загружает аргумент 0 в стек
//IL_0002:  ldc.i4.s    2A 
//IL_0004:  stind.i4	//Сохраняет значение по указанному адресу.    
//IL_0005:  ret  