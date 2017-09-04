<Query Kind="Program" />

interface IList 
{ 
    int Count { get; set; } 
}

interface ICounter
{
	void Count(int i);
}

interface IListCounter : IList, ICounter { }

class C
{
	void Test(IListCounter x)      // 1 
	{
		x.Count(1);                // 2 
		x.Count = 1;               // 3 
		// Count в IListCounter двузначный. Проблема
		//неоднозначности решается приведением x к соответствующему 
		//типу интерфейса. Например:
		//((IList)x).Count = 1;
		//((ICounter)x).Count(1);
	}
}