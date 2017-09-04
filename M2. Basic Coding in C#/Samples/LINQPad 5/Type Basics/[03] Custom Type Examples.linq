<Query Kind="Program" />

// Just as we can build complex functions from simple functions, we can build complex types from primitive types.
// UnitConverter serves a a blueprint for unit conversions:

public class UnitConverter
{
	int ratio;                                                     // Field
	public UnitConverter (int unitRatio) { ratio = unitRatio;   }  // Constructor
	public int Convert   (int unit)      { return unit * ratio; }  // Method
}

static void Main()
{
	UnitConverter feetToInchesConverter = new UnitConverter (12);
	UnitConverter milesToFeetConverter  = new UnitConverter (5280);

	Console.WriteLine (feetToInchesConverter.Convert (30));    // 360
	Console.WriteLine (feetToInchesConverter.Convert (100));   // 1200
	Console.WriteLine (feetToInchesConverter.Convert (milesToFeetConverter.Convert(1)));   // 63360
}