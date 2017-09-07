<Query Kind="Statements" />

//{
//	int single;
//	for (int i = 0; i < 10; i++)
//	{
//		single = 5;
//    	Console.WriteLine(single + i);
//	}
//}
//
//{
//	for (int i = 0; i < 10; i++)
//	{
//   		int multiple = 5;
//   		Console.WriteLine(multiple + i);
//	}
//}

Action[] actions = new Action[3];
for (int i = 0; i < 3; i++)
{
	actions[i] = delegate { Console.WriteLine(i); };
}
foreach(var action in actions) 
	action();