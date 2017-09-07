<Query Kind="Program" />

void Main()
{

}

class Person : ICloneable
{
	//любой код, ожидающий любой объект 
	//типа object будет работать по прежнему
	//называется ковариантностью возвращающих типов
	//механизмы реализации интерфейсов и переопределения 
	//методов ее не поддерживают
	//вместо этого так
	public Person Clone()
	{
		//Implementation goes here
		return new Person();
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	//Зеркальное отображение в ситуации формальных парамеров 
	//Имеется интерфейсный или виртуальный метод c сигнатурой
	void Process(string x) {}
	
	//Возможность реализации и переопределения данного 
	//метод с менее требовательной сигнатурой
	void Process(object x) {}
	//конравариантность типов параметров не поддерживается
}

//Method overriding and interface implementation 
//don’t allow covariance or contravariance