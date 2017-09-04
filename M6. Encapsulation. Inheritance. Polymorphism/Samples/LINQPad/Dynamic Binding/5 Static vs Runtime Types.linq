<Query Kind="Program" />

class Animal { }

class Dog : Animal
{
	public void Woof() { Console.WriteLine ("woof!"); }
}

void Main()
{
	dynamic x = new Dog();
	//dynamic как object в равной степени не описывает тип 
	//динамический объект связывается во время выполнения на 
	//основе типа времени выполнения
	//динамически связываемое выражение упаковывается компилятором так, чтобы
	//оно могло быть связано во время выполнения
	
	x.Woof();
}