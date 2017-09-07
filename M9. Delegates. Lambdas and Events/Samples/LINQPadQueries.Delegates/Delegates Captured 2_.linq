<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//Говорят, что экземпляр локальной переменной создается каждый раз, 
//когда поток выполнения входит в область действия, 
//в которой эта переменная объявлена

//Происходит вот что: один дополнительный класс создается для содержания 
//переменной outer, а другой — для содержания переменной inner и ссылки на первый 
//дополнительный класс. По существу, каждая область видимости, которая содержит  
//захваченную переменную, получает собственный тип со ссылкой на следующую область 
//видимости, которая содержит захваченную переменную. В данном случае было два  
//создается столько объектов анонимного типа, сколько экземпляров
//переменных захватывает анонимный метод!

delegate void MethodInvoker();

void Main()
{
	var delegates = new MethodInvoker[2]; 
	int outside = 0; // #1 Создает экземпляр переменной только однажды 
	for (int i = 0; i < 2; i++) 
	{ 
		int inside = 0; // #2 Создает экземпляр переменной многократно 
		delegates[i] = delegate // #3 Захват переменной анонимным методом 
		{ 
			Console.WriteLine ( " ({0} ,{1}) " , outside, inside); 
			outside++; 
			inside++; 
		}; 
	}

	delegates[0]();
	delegates[0]();
	delegates[0]();

	delegates[1]();
	delegates[1]();

	//	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
//		Assembly.GetExecutingAssembly().Location);
}