<Query Kind="Program" />

#region Валидация данных
//проблема валидации данных. Например, проверка введенного 
//адреса эл. почты, длины имени пользователя, сложности пароля и т.п. 
//Для валидации объекта возникает первая реализация:
#endregion

public class Product
{
    public int Price { get; set; }
 
    public bool IsValid()
    {
        return Price > 0;
    }
}
  void Main()
{
	// проверка на валидность
	var product = new Product { Price = 100 };
	var isValid = product.IsValid();
}

//Такой подход является вполне оправданным в данном случае. Код простой,
//тестированию поддается, дублирования логики нет.