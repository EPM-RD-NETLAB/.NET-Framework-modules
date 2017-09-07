<Query Kind="Program" />

//Анонимный метод может получить доступ к члену окружающего класса. 
//В случае статического члена очевидно, т.к. в домене приложения есть один 
//и только один экземпляр каждого статического поля. 
//Таким образом, нет никакого "захвата" статического поля.

//Доступ к членам экземпляров менее очевиден. 
//Cсылка this, обеспечивающая доступ к членам экземпляра, 
//есть локальная переменная внешнего метода экземпляров. 
//Следовательно, именно ссылка this захватывается анонимным методом.

delegate void DelegateTypeCounter();

class CounterBuilder
{
  	string name;
  	internal CounterBuilder(string name) { this.name = name; }

  	internal DelegateTypeCounter BuildCounter(string counterName) 
  	{
		int counter = 0;
		DelegateTypeCounter delegateInstanceCounter = delegate 
		{
	  		System.Console.Write(counterName + (++counter));
	  		System.Console.WriteLine(" Counter built by: " + this.name); 
		};
	return delegateInstanceCounter;
  }
}

static void Main() 
 {
	CounterBuilder cBuilder1 = new CounterBuilder("Factory1");
	CounterBuilder cBuilder2 = new CounterBuilder("Factory2");
	DelegateTypeCounter cA = cBuilder1.BuildCounter("Counter A:");
	DelegateTypeCounter cB = cBuilder1.BuildCounter("Counter B:");
	DelegateTypeCounter cC = cBuilder2.BuildCounter("Counter C:");
	cA.Dump();
	cA();  cA();
	cB.Dump();
	cB();  cB();
	cC.Dump();
	cC();  cC();cC();
}