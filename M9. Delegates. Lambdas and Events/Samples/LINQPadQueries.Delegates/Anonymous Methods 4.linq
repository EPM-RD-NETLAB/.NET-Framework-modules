<Query Kind="Program" />

delegate int DelegateType(int valTypeParam, string refTypeParam,
ref int refParam, out int outParam);

static DelegateType GetMethod()
{
	return delegate(int valTypeParam , string refTypeParam, ref int refParam , out int outParam   )
	{
		System.Console.WriteLine("Hello valParam:{0} refTypeParam:{1}", valTypeParam, refTypeParam);
	  	refParam++;
		outParam = 9;
		return valTypeParam;
	};
}

static void Main()
{
	DelegateType delegateInstance = GetMethod();
	int refVar = 5;
	int outVar;
	int i = delegateInstance(1, "one", ref refVar, out outVar);
	int j = delegateInstance(2, "two", ref refVar, out outVar);
	System.Console.WriteLine("i:{0} j:{1} refVar:{2} outVar:{3}", i, j, refVar, outVar);
}