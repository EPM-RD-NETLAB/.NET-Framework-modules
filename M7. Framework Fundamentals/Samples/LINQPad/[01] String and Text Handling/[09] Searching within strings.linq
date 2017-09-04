<Query Kind="Statements" />

// The simplest search methods are Contains, StartsWith, and EndsWith:
Console.WriteLine ("quick brown fox".Contains ("brown"));    // True
Console.WriteLine ("quick brown fox".EndsWith ("fox"));      // True

// IndexOf returns the first position of a given character or substring:
Console.WriteLine ("abcde".IndexOf ("cd"));   // 2
Console.WriteLine ("abcde".IndexOf ("xx"));   // -1

// IndexOf is overloaded to accept a startPosition StringComparison enum, which enables case-insensitive searches:
Console.WriteLine ("abcde".IndexOf ("CD", StringComparison.CurrentCultureIgnoreCase));    // 2

// LastIndexOf is like IndexOf, but works backward through the string.
// IndexOfAny returns the first matching position of any one of a set of characters:
Console.WriteLine ("ab,cd ef".IndexOfAny (new char[] {' ', ','} ));       // 2
Console.WriteLine ("pas5w0rd".IndexOfAny ("0123456789".ToCharArray() ));  // 3

// LastIndexOfAny does the same in the reverse direction.