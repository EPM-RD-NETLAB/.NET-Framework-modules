<Query Kind="Program" />

delegate void DelegateType(params int[] arr);
	
static DelegateType GetMethod()
{
	// Ошибка компиляции: param в данном контексте неприменимо.//атрибуты!
	return delegate(params int[] arr){ Console.WriteLine("Hello");};
}

void Main()
{
	
}