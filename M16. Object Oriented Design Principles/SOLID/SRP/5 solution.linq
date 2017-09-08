<Query Kind="Program" />

//Имеем объект Product отдельно, а любое количество 
//всяческих валидаторов отдельно.

public interface IProductValidator
{
    bool IsValid(Product product);
}
 
public class ProductDefaultValidator : IProductValidator
{
    public bool IsValid(Product product)
    {
        return product.Price > 0;
    }
}
 
public class CustomerServiceProductValidator : IProductValidator
{
    public bool IsValid(Product product)
    {
        return product.Price > 100000;
    }
}
 
public class Product
{
    private readonly IProductValidator validator;
 
    public Product() : this(new ProductDefaultValidator())
    {
    }
 
    public Product(IProductValidator validator)
    {
        this.validator = validator;
    }
 
    public int Price { get; set; }
 
    public bool IsValid()
    {
        return validator.IsValid(this);
    }
}
void Main()
{
	// обычное использование
	var product = new Product { Price = 100 };
 
	// используем объект продукта в новом сервисе
	var product1 = new Product (new CustomerServiceProductValidator()) { Price = 100 };
}


public class ValidationService<T>
{
  private List<IValidator> _validators;

  public List<Error> Validate(T objectToValidate)
  {
    foreach(IProductValidator validator in _validators)
    {
      yield return validator.Validate(objectToValidate);
    }
  }
}


public class CompositeProductValidator : IProductValidator
{
	private readonly IEnumerable<IProductValidator> validators;
	public CompositeProductValidator(IEnumerable<IProductValidator> validators) 
	{ 
		this.validators = validators; 
	}

	public bool IsValid(Product product) 
	{ 
		return validators.All(v => v.IsValid(product)); 
	}
}