<Query Kind="Program" />

//в обычных методах оператор return имеет два эффекта
//представляет значение, которое вызывающая сторона видит, как возвращаемое 
//обеспечивает выполнение любых соответсвующих блоков finally на выходе
public static IEnumerable<int> GetNumbers()
{
	try
	{
		yield return 7;
		yield return 42;
	}
	finally
	{
		Console.WriteLine("Внутри блока finally метода GetNumbers");
	}
}
		
void Main()
{
	//IEnumerable<int> iterator = GetNumbers();
	foreach (var i in GetNumbers())
	{
		i.Dump();
	}
		Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
	Assembly.GetExecutingAssembly().Location);
}
#region Advanced
//Если блок итератора содержит блок finally, то весь код, расположенный в этом 
//блоке помещается в отдельный метод (в метод m_Finally3()),
//который будет вызван в следующих случаях:

//1) после нормального завершения итерирования коллекции (либо после вызова
//yield break, либо после обыкновенного завершения блока итератора);

//2) в случае генерации исключения в блоке итератора (вы могли обратить внимание 
//на ключевое слово fault вместо finally; это не ошибка, такого ключевого слова 
//нет в языке C#, но такая конструкция существует языке IL, которая означает, 
//что этот фрагмент кода будет выполнен только в случае генерации исключения, 
//после чего исключение будет проброшено далее по стеку);

//3) в случае вызова метода Dispose.
#endregion