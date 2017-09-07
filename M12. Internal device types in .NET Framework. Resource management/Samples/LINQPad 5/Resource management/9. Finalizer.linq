<Query Kind="Program" />

//Может ли объект стать "мусором" до окончания вызова конструктора?
#region Advanced
// - Выделение памяти в управляемой куче.
// - Добавление указатель на вновь созданный объект в очередь
//для финализации.
// - Вызвать конструктор объекта.
//Таким образом, объект добавляется в очередь для финализации
//до вызова конструктора, что дает гарантию вызова финализатора
//даже если конструктор сгенерирует исключение.
#endregion

class Racer
{
    private readonly int _x;
 
    public Racer(int x)
    {
        _x = x;
        Print("ctor", _x);
    }
 
    ~Racer()
    {
        Print("dtor", _x);
    }
 
    public static void Print(string message, int objectId)
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
 
        Console.WriteLine("{0}, object id: {1}", message, objectId);
    }
}
 

public static void Main()
{
    var racer = new Racer(42);
}

//Выделение памяти в управляемой куче.

//Добавление указатель на вновь созданный объект в очередь
//для финализации.

//Вызвать конструктор объекта.