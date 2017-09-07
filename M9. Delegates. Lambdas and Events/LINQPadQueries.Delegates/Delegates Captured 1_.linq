<Query Kind="Statements" />

//Поведение “захваченных” переменных
//при замыкании осуществляется захват переменной, 
//а не захват значения переменной, которое было перед 
//определением делегата вместо локальной переменной 
//captured используется поле анонимного типа

string captured = "before x is created";

Action x = delegate
{
   Console.WriteLine(captured);
   captured = "changed by x";
};

captured = "directly before x is invoked";
x();
Console.WriteLine(captured);

captured = "before second invocation";
x();
Console.WriteLine(captured);