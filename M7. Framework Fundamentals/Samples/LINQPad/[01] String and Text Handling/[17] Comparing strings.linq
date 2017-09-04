<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// String comparisons can be ordinal vs culture-sensitive; case-sensitive vs case-insensitive.

Console.WriteLine (string.Equals ("foo", "FOO", StringComparison.OrdinalIgnoreCase));   // True

// (The following symbols may not be displayed correctly, depending on your font):
Console.WriteLine ("ṻ" == "ǖ");   // False

// The order comparison methods return a positive number, a negative number, or zero, depending
// on whether the first value comes after, before, or alongside the second value:
Console.WriteLine ("Boston".CompareTo ("Austin"));    // 1
Console.WriteLine ("Boston".CompareTo ("Boston"));    // 0
Console.WriteLine ("Boston".CompareTo ("Chicago"));   // -1
Console.WriteLine ("ṻ".CompareTo ("ǖ"));              // 0
Console.WriteLine ("foo".CompareTo ("FOO"));          // -1

// The following performs a case-insensitive comparison using the current culture:
Console.WriteLine (string.Compare ("foo", "FOO", true));   // 0

// By supplying a CultureInfo object, you can plug in any alphabet:
CultureInfo german = CultureInfo.GetCultureInfo ("de-DE");
int i = string.Compare ("Müller", "Muller", false, german);
i.Dump();	// 1