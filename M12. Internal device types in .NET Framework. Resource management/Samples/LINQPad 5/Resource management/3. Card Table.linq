<Query Kind="Program" />

class Customer
{
    public Order LastOrder { get; set; }
}
class Order { }

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        GC.Collect();
        GC.Collect();

        // теперь объект customer находится в поколении 2 
        customer.LastOrder = new Order();
		Debug.WriteLine("A resides in Gen {0}, A.B resides in Gen {1}",
		GC.GetGeneration(customer), GC.GetGeneration(customer.LastOrder));
		GC.Collect();
        GC.Collect();
		Debug.WriteLine("A resides in Gen {0}, A.B resides in Gen {1}",
		GC.GetGeneration(customer), GC.GetGeneration(customer.LastOrder));
    }
}