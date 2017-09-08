<Query Kind="Program" />

//Теперь наш объект Product начал использовать в некоем CustomerService, 
//который считает валидным продукт с ценой больше 100 тыс. рублей. 
//Что делать? Уже сейчас понятно, что нам придется изменять наш 
//объект продукта, например, таким образом:

public class Product
{
    public int Price { get; set; }
 
    public bool IsValid(bool isCustomerService)
    {
        if (isCustomerService == true)
            return Price > 100000;
 
        return Price > 0;
    }
}
 void Main()
{
	// используем объект продукта в новом сервисе
	var product = new Product { Price = 100 };
	var isValid = product.IsValid(true);
}
