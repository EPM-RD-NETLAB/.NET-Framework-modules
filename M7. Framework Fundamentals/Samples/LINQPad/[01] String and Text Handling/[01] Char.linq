<Query Kind="Statements" />

// char literals:
char c = 'A';
char newLine = '\n';

// System.Char defines a range of static methods for working with characters:
Console.WriteLine (char.ToUpper ('c'));				// C
Console.WriteLine (char.IsWhiteSpace ('\t'));		// True
Console.WriteLine (char.IsLetter ('x'));			// True
Console.WriteLine (char.GetUnicodeCategory ('x'));	// LowercaseLetter