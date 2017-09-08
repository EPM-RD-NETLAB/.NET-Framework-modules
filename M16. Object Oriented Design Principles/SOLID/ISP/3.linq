<Query Kind="Program" />

#region Проблема «Жирный» интерфейс
//У нас есть интерфейс ISpecification. С помощью него мы можем узнать подходит 
//ли продукт заявке – метод IsSuitable и является ли поле продукта измененным – 
//метод IsFieldChanged:
#endregion

public interface ISpecification
{
	bool IsSuitable(Product realty, Offer offer);
	
	bool IsFieldChanged(Product oldValue, Product newValue);
}
//Чем является наш модуль для сторонних клиентов? Он является набором интерфейсов, 
//с помощью которых модуль может быть использован. В данном случае проблема заключается в том, 
//что клиентом первой функции является консольное приложение, а второй – класс хранилища:
  
/// <summary>
/// Хранилище для продуктов
/// </summary>
public class ProductRepository : IRepository<product>
{
	public void Save(Product product)
	{
		// ...
  		specification.IsFieldChanged();
  		// ...
	}
}
  
/// <summary>
/// Программа расчета подходящих продуктов
/// </summary>
public class Program
{
	public static void Main(string[] args)
	{
		// ...
  		specification.IsSuitable();
	}
}
//Допустим, что мы уже написали несколько конкретных спецификаций:
class PriceSpecification : ISpecification
{
	public bool IsSuitable(Product realty, Offer offer)
	{
		// ...
	}
  
	public bool IsFieldChanged(Product oldValue, Product newValue)
	{
		// ...
	}
}
//Уже видно, что полученный результат нас не устраивает. 
//При рефакторинге или изменинии логики в консольном приложении и методе IsSuitable, 
//нам придется затронуть все классы, которые реализовали интерфейс ISpecification.
//Например, представьте, что будет если в метод IsSuitable мы захотим добавить еще 
//один параметр? А если конкретных спецификаций накопилось уже с десяток? Основная 
//мысль в том, что теперь различные части системы зависят друг от друга, хоть и косвенно.
//Консольное приложение зависит от логики хранилища и наоборот.

//Главное правило в данном случае звучит так: если клиенты интерфейса разделены,
//то и интерфейс должен быть разделен соответствующим образом.

public interface ISpecification
{
	bool IsSuitable(Product realty, Offer offer);
}
  
public interface IChangeFieldDetector
{
	bool IsFieldChanged(Product oldValue, Product newValue);
}

//Теперь консольное приложение работает интерфейсом ISpecification, 
//а хранилище работает с интерфейсом IChangeFieldDetector. Проблема с зависимостью решена.

//Кроме этого, мы решили еще и проблему с наследниками первой реализации ISpecification.
//Теперь класс может реализовывать только один интерфейс, за счет чего его на много проще поддерживать:

class PriceSpecification : ISpecification
{
	public bool IsSuitable(Product realty, Offer offer)
	{
		// ...
	}
}
  
class PriceChangeFieldDetector : IChangeFieldDetector
{
	public bool IsFieldChanged(Product oldValue, Product newValue)
	{
		// ...
	}
}