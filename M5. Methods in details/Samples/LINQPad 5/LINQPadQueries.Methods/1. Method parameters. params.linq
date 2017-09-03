<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

#region Overload resolution
//Разрешение перегрузки (Overload resolution) – механизм времени компиляции
//выбора функции из множества перегруженных версий, 
//основанный на анализе аргументов
#endregion

public static void Main()
{
	Console.WriteLine(Add(new int[] { 1, 2, 3, 4, 5 }));
	Console.WriteLine(Add(1, 2, 3, 4, 5));
	int[] arr = new int[] { 1, 2, 3, 4, 5 };
	Console.WriteLine(Add(arr));
	Console.WriteLine(AddArr(arr));
	Console.WriteLine(Add(1, 2, 3));
	Console.WriteLine(Add());
	Console.WriteLine(AddArr(new int[] { 1, 2, 3, 4, 5 }));
	DisplayTypes(new Object(), new Random(), ".NET Framework 4.0", 5);
	Console.WriteLine("0", 1, 2, 3, 4, 5);
	Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);

}

private static int Add(params int[] values)
{
	Console.WriteLine("Works method with params");
	int sum = 0;
	for (var i = 0; i < values.Length; i++)
	{
		sum += values[i];
	}
	return sum;
}

private static int AddArr(int[] array)
{
	Console.WriteLine("Works method with arrat as parametr");
	int sum = 0;
	for (var i = 0; i < array.Length; i++)
		sum += array[i];
	return sum;
}

//!!!!
//private static int Add(int[] array)
//{
//	int sum = 0;
//	for (var i = 0; i < array.Length; i++)
//		sum += array[i];
//	return sum;
//}

private static int Add(int one, int two, int three)
{
	Console.WriteLine("Works method with 3 parametrs");
	return one + two + three;
}

private static void DisplayTypes(params Object[] objects)
{
	foreach (Object o in objects)
		Console.WriteLine(o.GetType());
}