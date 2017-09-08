<Query Kind="Program" />

#region ISP
//Принцип разделения интерфейса (Interface Segregation Principle)
//Формулировка: клиенты не должны зависеть от методов, которые они не используют
//либо клиент не должен вынужденно зависеть от элементов интерфейса, которые он не использует.
//другими словами этот принцип можно сформулировать так: зависимость между классами 
//должна быть ограничена как можно более узким интерфейсом
//Как и при использовании других принципов проектирования классов мы пытаемся 
//избавиться от ненужных зависимостей в коде, сделать код легко читаемым и 
//легко изменяемым.
#endregion

#region Проблема Лишняя абстракция в наследовании
//Речь идет о базовых классах, которые вынуждают своих наследников знать и делать 
//слишком много. Печально известный пример – класс MembershipProvider. 
//Для использования этого класса нужно реализовать 27 абстрактных методов и свойств.

//Есть базовый класс для аудиторов EntityAuditor.
//Он унаследован от класса AuditorBase, который предоставляет ORM, и реализует метод 
//AuditEntityFieldSet этого базового класса. Также EntityAuditor добавляет свой а
//бстрактный метод CreateLogRow, который используется в методе AuditEntityFieldSet
//и должен быть переопределен в конкретных реализациях:
#endregion

public abstract class EntityAuditor : AuditorBase
{
	public override void AuditEntityFieldSet(IEntityCore entity, int fieldIndex, object originalValue)
	{
		// ...
		 
		CreateLogRow();
		 
		// ...
	}
  
	protected abstract LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity);
}
//После этого начинаем реализовывать наследников. 
//Например, создадим аудитор для класса Product:
public class ProductAuditor : EntityAuditor
{
	protected override LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity)
	{
		// ...
	}
}
//Сейчас добавлению наследников ничего не мешает. Теперь представим, что в методе AuditEntityFieldSet
//понадобилась дополнительная логика, при которой нужно вызвать метод UpdateDuplicates.
//Этот метод также является абстрактным и требует реализации в наследниках:
public abstract class EntityAuditor : AuditorBase
{
	public override void AuditEntityFieldSet(IEntityCore entity, int fieldIndex, object originalValue)
	{
		// ...
		CreateLogRow();
  		UpdateDuplicates();
		// ...
	}
  
	protected abstract LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity);
  
	protected abstract void UpdateDuplicates(IEntityCore entity, decimal fieldId, object current);
}

public class ProductAuditor : EntityAuditor
{
	protected override LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity)
	{
		// ...
	}
  
	protected override void UpdateDuplicates(IEntityCore entity, decimal fieldId, object current)
	{
		// реализация
	}
}
  
public class AccountAuditor : EntityAuditor
{
	protected override LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity)
	{
		// ...
	}
  
	protected override void UpdateDuplicates(IEntityCore entity, decimal fieldId, object current)
	{
		// здесь ничего нет!
	}
}

//EntityAuditor требует реализации метода UpdateDuplicates даже в тех наследниках,
//где он не нужен, как, например, в AccountAuditor. Проблема в том, что частный случай 
//(UpdateDuplicates), который используется только в половине наследников, мы сделали 
//общим, т.е. обязательным для всех наследников нашего EntityAuditor. Получается, 
//что чем больше наследников будет у EntityAuditor, тем больше бесполезного кода 
//мы будем писать, тем больше наследники будут знать лишнего о своем базовом классе.
//Это может сильно помешать нам в дальнейшем при рефакторинге или изменении логики в EntityAuditor.

//В данном случае решение очень простое. Если наследникам класса EntityAuditor 
//не нужна функция UpdateDuplicates, то и реализовывать ее они не должны. 
//В С# это делается простой заменой ключевого слова abstract на virtual:
public abstract class EntityAuditor : AuditorBase
{
	public override void AuditEntityFieldSet(IEntityCore entity, int fieldIndex, object originalValue)
	{
		// ...
		CreateLogRow();
		UpdateDuplicates();
		// ...
	}
  
	protected abstract LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity);
  
	protected virtual void UpdateDuplicates(IEntityCore entity, decimal fieldId, object current)
	{
	}
}
//Теперь наследники отчищены от ненужной связности:
public class ProductAuditor : EntityAuditor
{
	protected override LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity)
	{
		// ...
	}
  
	protected override void UpdateDuplicates(IEntityCore entity, decimal fieldId, object current)
	{
		// реализация
	}
}
  
public class AccountAuditor : EntityAuditor
{
	protected override LogRowEntity CreateLogRow(decimal? fieldId, string oldValue, string newValue, IEntityCore entity)
	{
		// ...
	}
}