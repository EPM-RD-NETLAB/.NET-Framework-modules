<Query Kind="Program" />

[Flags] public enum BorderSides { Left=1, Right=2, Top=4, Bottom=8 }

static void Main()
{
	int i = (int) BorderSides.Top;            // i == 4
	BorderSides side = (BorderSides) i;       // side == BorderSides.Top
	
	GetIntegralValue (BorderSides.Top).Dump();
	GetAnyIntegralValue (BorderSides.Top).Dump();
	
	object result = GetBoxedIntegralValue (BorderSides.Top);
	Console.WriteLine (result);                               // 4
	Console.WriteLine (result.GetType());                     // System.Int32
	
	GetIntegralValueAsString (BorderSides.Top).Dump();
}

static int GetIntegralValue (Enum anyEnum) 
	=> (int) (object) anyEnum;

static decimal GetAnyIntegralValue (Enum anyEnum) 
	=> Convert.ToDecimal (anyEnum);

static object GetBoxedIntegralValue (Enum anyEnum)
{
	Type integralType = Enum.GetUnderlyingType (anyEnum.GetType());
	return Convert.ChangeType (anyEnum, integralType);
}

static string GetIntegralValueAsString (Enum anyEnum) 
	=> anyEnum.ToString ("D");      // returns something like "4"
