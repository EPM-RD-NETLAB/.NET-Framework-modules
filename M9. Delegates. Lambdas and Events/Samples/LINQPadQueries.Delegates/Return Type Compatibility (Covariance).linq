<Query Kind="Program" />

// В результате вызова метода можно получить результат более 
// срецифичного типа, чем запрошенный
// по этой причине целевой метод делегата может возращать более
// специфичный, чем сам делегат
// Ковариация (ковариантность)
delegate object CovariantAndContavariantDelegate(string obj);
delegate object ObjectRetriever();

static void Main()
{
	ObjectRetriever o = new ObjectRetriever(RetriveString);
	object result = o();
	Console.WriteLine (result);
	
	CovariantAndContavariantDelegate del = TargetMethodForDelegate;
	del(5.ToString()).Dump();
}

static string TargetMethodForDelegate(object obj)
{ 
	return obj.ToString(); 
}

static string RetriveString() { return "return string"; }
//static int RetriveInteger() { return 1; }