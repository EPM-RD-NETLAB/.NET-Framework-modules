<Query Kind="Program" />

#region Проблема 2 (Проверка типа абстракции)
//Этот пример в разных вариациях все не раз видели в коде. 
//Его хоть в рамку можно вешать, как самое популярное 
//нарушение проектирования. У нас есть иерархия объектов 
//с абстрактным родительским классом AbstractEntity и 
//класс Repository, который использует абстракцию. 
//При этом вызывая метод Save у Repository мы строим 
//логику в зависимости от типа входного параметра:
//
//Из кода видно, что объект Repository придется менять каждый раз, 
//когда мы добавляем в иерархию объектов с базовым классом 
//AbstractEntity новых наследников или удаляем существующих.
//Условные операторы будут множится в методе Save и тем самым усложнять его.
#endregion

public abstract class AbstractEntity{ }
 
public class AccountEntity : AbstractEntity{ }
 
public class RoleEntity : AbstractEntity{ }
 
public class Repository
{
	public void Save(AbstractEntity entity)
	{
		if (entity is AccountEntity)
		{
			// специфические действия для AccountEntity
		}
		if (entity is RoleEntity)
		{
			// специфические действия для RoleEntity
		}
	}
}
