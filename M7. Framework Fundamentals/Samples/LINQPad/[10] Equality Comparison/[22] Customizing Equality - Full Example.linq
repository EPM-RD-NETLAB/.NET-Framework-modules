<Query Kind="Program" />

public struct Area : IEquatable <Area>
{
	public readonly int Measure1;
	public readonly int Measure2;
	
	public Area (int m1, int m2)
	{
		Measure1 = Math.Min (m1, m2);
		Measure2 = Math.Max (m1, m2);
	}
	
	public override bool Equals (object other)
	{
		if (!(other is Area)) return false;
		return Equals ((Area) other);        // Calls method below
	}
	
	public bool Equals (Area other)        // Implements IEquatable<Area>
		=> Measure1 == other.Measure1 && Measure2 == other.Measure2;
	
	public override int GetHashCode()
		=> Measure2 * 31 + Measure1;    // 31 = some prime number
	
	public static bool operator == (Area a1, Area a2)
		=> a1.Equals (a2);
	
	public static bool operator != (Area a1, Area a2)
		=> !a1.Equals (a2);
}

static void Main()
{
	Area a1 = new Area (5, 10);
	Area a2 = new Area (10, 5);
	Console.WriteLine (a1.Equals (a2));    // True
	Console.WriteLine (a1 == a2);          // True
}