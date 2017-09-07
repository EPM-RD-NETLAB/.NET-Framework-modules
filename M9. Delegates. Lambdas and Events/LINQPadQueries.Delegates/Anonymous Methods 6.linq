<Query Kind="Program" />

//При объявлении анонимного метода можно обойтись без сигнатуры, т.е. не обязательно писать
//пару скобок 
//после ключевого слова delegate, если метод не принимает аргументов.
//В этом случае метод должен быть присвоен экземпляру делегата, который возвращает тип void и
//не имеет out-аргументов. Очевидно, такой анонимный метод не имеет доступа к параметрам, 
//которые присутствуют в вызове экземпляра делегата.

delegate void DelegateType(int valTypeParam, string refTypeParam, ref int refParam);

static void Main() 
{
	DelegateType delegateInstance = delegate 
	{ 
	  	Console.WriteLine("Hello"); 
	};
	int refVar = 5;
	delegateInstance(1, "one", ref refVar);
	delegateInstance(2, "two", ref refVar);
}