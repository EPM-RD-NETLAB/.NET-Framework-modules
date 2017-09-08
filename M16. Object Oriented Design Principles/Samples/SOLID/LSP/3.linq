<Query Kind="Program" />

//В проекте есть интерфейс IList и два наследника: List и DoubleList.
//DoubleList своеобразно реализует метод Add - он добавляет переданный 
//ему объект дважды. Это значит, когда мы добавим один элемент в DoubleList, 
//свойство Count вернет цифру 2, а по индексу 0 и 1 вернутся два одинаковых элемента.
public class DoubleList<T> : IList<T>
{
	private readonly IList<T> innerList = new List<T>();//List : IList!!!
  
	public void Add(T item)
	{
		innerList.Add(item);
		innerList.Add(item);
	}
  
	//...
}

public void SomeMethod(IList<string> list)
{
	List<string> urls = urlService.GetUrls();
 
	foreach(string url in urls)
	{
		if (SomeBoolLogic(url))
			list.Add(url);
	}
 
	if (urls.Count > list.Count)//*
		throw Exception();
}

//Результаты сравнения свойств Count (* строка) будут отличаться в зависимости
//от того, какой из наследников интерфейса IList будет передан в метод SomeMethod.
//Если вы передадите экземпляр класса List, то элементов будет меньше, 
//а если DoubleList, то больше (функция Add добавляет по два объекта за раз). 
//Т.е. результат этой функции будет зависеть от конкретной реализации IList.

//Программист, который привык, что эта функция работает с любым наследником IList,
//посидев в дебагере, поймет, что иногда (когда приходит DoubleList) 
//эта функция не работает. Программист добавит код-костыль, чтобы поправить 
//последствия неправильного наследования DoubleList от IList:

public void SomeMethod(IList<string> list)
{
	List<string> urls = urlService.GetUrls();
	foreach(string url in urls)
	{
		if (SomeBoolLogic(url))
			list.Add(url);
	}
 
	// начало костыля
	int realCount;
 
	if (list is DoubleList)
		realCount = list.Count / 2;
	else
		realCount = list.Count;
	// конец костыля
 
	if (urls.Count > realCount)
		throw Exception();
}

//Нарушение контракта интерфейса IList привело к использованию оператора is
//(или as).
//Если какой-то разработчик создаст TripleList, унаследует его от IList, 
//то еще больше усложнит жизнь своего проекта.

//Корни проблемы лежат в непонимании принципов ООП. Вы должны свободно использовать 
//абстракцию у себя в коде, без лишних проверок на тип. Использование операторов 
//is и as должно быть очень веско обосновано, т.к. чаще всего они являются первыми
//признаками нарушения LSP.

//Или давайте еще проще. Когда вы берете элементы по индексу, то ожидаете, 
//что индекс будет считаться с 0. Возьмите наследника IList, сделайте индекс
//не с 0, а с 1 и вас возненавидит вся команда. Причем желательно, чтобы в системе
//был другой IList, который считает с 0.
