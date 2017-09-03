<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Third version
//http://habrahabr.ru/post/130318/
// Third version - thread-safety using double-check locking
#endregion

public sealed class Singleton
{
	private static volatile Singleton instance = null;
	#region volatile
	//Ключевое слово volatile указывает, что поле может быть изменено 
	//несколькими потоками, выполняющимися одновременно.
	//Поля, объявленные как volatile, не проходят оптимизацию компилятором,
	//которая предусматривает доступ посредством отдельного потока. 
	//Это гарантирует наличие наиболее актуального значения в поле в 
	//любое время.
	//Без этого вполне возможна ситуация, когда другой поток, обращающийся к 
	//свойству instance, получит доступ к частично валидному экземпляру 
	//синглтона, конструирование которого еще не завершено.
	//Причина такого поведения заключается в следующем. Создание экземпляра
	//с помощью instance = new Singleton(); не является атомарной операцией,
	//а состоит(упрощенно) из следующих этапов.
	// 1. Выделение памяти в управляемой куче.
	// 2. Конструирование объекта по указанному адресу (вызов конструктора).
	// 3. Инициализация поля instance.
	// Если поле instance не помечено ключевым словом volatile,
	//то компилятор имеет право изменить порядок этих операций.
	//И если он поменяет 2-й и 3-й шаги местами для одного потока, 
	//то другой поток вполне сможет «увидеть», что поле instance
	//уже проинициализировано, и начнет использовать еще не 
	//сконструированный объект.

	#endregion
	private static readonly object padlock = new object();

	Singleton() { }

	public static Singleton Instance
	{
		get
		{
			if (instance == null)
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new Singleton();
					}
				}
			}
			return instance;
		}
	}
}

void Main() { }