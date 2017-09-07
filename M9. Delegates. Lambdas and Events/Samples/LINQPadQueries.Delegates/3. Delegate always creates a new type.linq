<Query Kind="Program" />

//Делегат при описании создает новый тип!!!
//При этом два делегата с одинаковой сигнатурой являются разными типами,
//не совместимыми (не приводимыми) между собой.

delegate void Delegate1();
delegate void Delegate2();

static void Method() { }

static void Main()
{
	Delegate1 del1 = new Delegate1(Method);
	Delegate2 del2 = new Delegate2(Method);
	del1.GetHashCode().Dump();
	del2.GetHashCode().Dump();
	//(del1 == del2).Dump();
	//Cannot implicitly convert type 'UserQuery.MyDelegate2' to 'UserQuery.MyDelegate1'
	//del1 = del2;
	del2 = del1.Invoke;//del2 = new Delegate2(del1.Invoke);
	del2.Dump();
	Delegate2 del3 = new Delegate2(del1);//Законно!
	del3.Dump();
}