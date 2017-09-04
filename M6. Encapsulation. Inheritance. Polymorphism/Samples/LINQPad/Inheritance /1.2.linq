<Query Kind="Program" />

//CLR поддерживает две базовые стратегии использования 
// одинаковых имен методов базового и производного типов:
// 
// - hide-by-signature сокрытие по сигнутуре - 
//скрытыми будут только базовые методы с тем же 
//именем и той же сигнатурой, остальные методы отстануться 
//видимой частью контракта производного типа

// - hide-by-name сокрытие по имени
//скрытыми будут только базовые методы с тем же 
//именем и той же сигнатурой -
//производный метод скрывает все методы базового класса
//с тем же именем независимо от их сигнатуры

//в типах C# - hide-by-signature only!
void Main()
{
	Derived d = new Derived();
	Base b = d;
	d.x = 100;
	b.x = 200;
	
//	d.Dump();
//	b.Dump();
	
	d.Foo();
	b.Foo();
	
	d.Foo("string");
	d.Foo(1);
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

public class Base
{
	public int x;
	
	public void Foo()
	{
		"Base->Foo()".Dump();
	}
	public void Foo(object o)
	{
		"Base->Foo(object)".Dump();
	}
}

public class Derived : Base
{
	public new int x;
	//в сценарии коллизии имен методов действуют правила отличные от сценария
	//колллизии имен полей, поскольку возможна перегрузка методов
	public new void Foo()
	{
		"Derived->Foo()".Dump();
	}
	
	public void Foo(int x)
	{
		"Derived->Foo(int)".Dump();
		this.x = x + 1;
		base.x = x + 2;
	}
}