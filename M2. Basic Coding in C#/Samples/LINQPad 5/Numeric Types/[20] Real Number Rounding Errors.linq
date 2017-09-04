<Query Kind="Statements" />

// Unlike decimal, float and double can cannot precisely represent numbers with a base-10 fractional component:
{
	float tenth = 0.1f;                       // Not quite 0.1
	float one   = 1f;
	Console.WriteLine (one - tenth * 10f);    // -1.490116E-08
}
{
	decimal tenth = 0.1m;                     // Exactly 0.1
	decimal one   = 1m;
	Console.WriteLine (one - tenth * 10m);    // 0.0
}

// Neither double nor decimal can precisely represent a fractional number whose base 10 representation is recurring:
decimal m = 1M / 6M;               // 0.1666666666666666666666666667M
double  d = 1.0 / 6.0;             // 0.16666666666666666

m.Dump ("m"); d.Dump ("d");

// This leads to accumulated rounding errors:
decimal notQuiteWholeM = m+m+m+m+m+m;  // 1.0000000000000000000000000002M
double  notQuiteWholeD = d+d+d+d+d+d;  // 0.99999999999999989

// which breaks equality and comparison operations:
Console.WriteLine (notQuiteWholeM == 1M);   // False
Console.WriteLine (notQuiteWholeD < 1.0);   // True