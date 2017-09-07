<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

delegate void MethodInvoker();

void Main()
{
	var delegates = new MethodInvoker[2]; 
	int outside = 0;
	for (int i = 0; i < 2; i++) 
	{ 
		int inside = 0;
		delegates[i] = delegate // #3 Захват переменных анонимным методом 
		{ 
			++outside;
			++inside;
			Console.WriteLine(" ({0} ,{1}) ", outside, inside);
		};
	}

	delegates[0]();
	delegates[1]();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}