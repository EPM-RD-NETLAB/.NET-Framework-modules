<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// ToUpper and ToLower honor the end-user’s locale, which can lead to subtle bugs.
// This applies to both char and string.

// To illustrate, let's pretend we live in Turkey:
Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo ("tr-TR");

// The following expression evaluates to false:
Console.WriteLine (char.ToUpper ('i') == 'I');

// Let's see why:
Console.WriteLine (char.ToUpper ('i'));   // İ

// In contrast, the *Invariant methods always apply the same culture:
Console.WriteLine (char.ToUpperInvariant ('i'));			// I
Console.WriteLine (char.ToUpperInvariant ('i') == 'I');		// True