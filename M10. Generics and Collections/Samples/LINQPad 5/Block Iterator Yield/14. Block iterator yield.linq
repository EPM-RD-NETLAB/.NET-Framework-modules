<Query Kind="Program" />

//Реальные примеры использования итераторов

//using (TextReader reader = File.OpenText(filename))//using
//        {
//           string line;
//           while ((line = reader.ReadLine()) != null)//перебор
//           {
//              // Do something with line
//           }
//}

//1. как получить TextReader
//2. управлять продолжительностью его жизни(!)
//3. перебор строк reader.ReadLine()(!)
//4. собственно обработка этих строк

public static IEnumerable<string> ReadLines(string filename)
{
	using (TextReader reader = File.OpenText(filename))
	{
		string line;
		while ((line = reader.ReadLine()) != null)
		{
			yield return line;
			throw new FileNotFoundException();
		}
	}
}

void Main()
{
	string path = @"Z:\MIB On My Mac\Desktop\LINQPadQueries for training\LINQPadQueries.Iterator\text.txt";//AppDomain.CurrentDomain.BaseDirectory
	try
	{	        
		foreach (var s in ReadLines(path))
			Console.WriteLine(s);//TODO
	}
	catch{}
	
	foreach (var s in ReadLines(path))
		Console.WriteLine(s);
		
	//прямой вызов метода GetEnumerator может поломать логику очистки ресурсов
	
	//работать с другим потоком
	//использовать другую кодировку
	
	//сохранить аспекты управления временем 
	//жизни ридера и итерирования в одном методе
}