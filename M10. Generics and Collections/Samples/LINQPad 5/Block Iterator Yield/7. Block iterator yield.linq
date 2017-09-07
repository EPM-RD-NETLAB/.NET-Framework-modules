<Query Kind="Program" />

//Reset always throws an NotSupportedException instead of resetting like your
//manual implementation did.This is required behavior,
//laid down in the specification. 
//Failing to implement Reset is reasonable—the compiler can’t work 
//out what you’d need to do in order to reset the iterator, or even 
//whether it’s feasible. Arguably Reset shouldn’t have been in the 
//IEnumerator interface to start with, and I can’t remember the last 
//time I called it. Many collections don’t support it, so callers can’t
//generally rely on it anyway.
//- The nested class always implements both the generic
//and nongeneric forms ofIEnumerator(and the generic
//and nongeneric IEnumerable, where appropriate).
void Main()
{
	var iterator = CountToTen().GetEnumerator();
	//До первого вызова метода  MoveNext, свойство Current
	//будет всегда возвращать значение поумолчанию
	iterator.Current.Dump();
	iterator.MoveNext();
	iterator.Current.Dump();
	iterator.Current.Dump();
	//После того, как метод MoveNext вернет последнее значение,
	//свойство Current будет всегда возвращать последнее значение
	iterator.Current.Dump();
	iterator.Reset();
}

IEnumerable<int> CountToTen()
{
	System.Console.WriteLine("1");
	yield return 1000;
//	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
//		Assembly.GetExecutingAssembly().Location);
}