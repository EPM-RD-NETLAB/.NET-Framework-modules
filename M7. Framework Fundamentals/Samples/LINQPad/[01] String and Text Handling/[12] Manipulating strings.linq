<Query Kind="Statements" />

// Because String is immutable, all the methods below return a new string, leaving the original untouched.

// Substring extracts a portion of a string:
string left3 = "12345".Substring (0, 3);     // left3 = "123";
string mid3  = "12345".Substring (1, 3);     // mid3 = "234";

// If you omit the length, you get the remainder of the string:
string end3  = "12345".Substring (2);        // end3 = "345";

// Insert and Remove insert or remove characters at a specified position:
string s1 = "helloworld".Insert (5, ", ");    // s1 = "hello, world"
string s2 = s1.Remove (5, 2);                 // s2 = "helloworld";

// PadLeft and PadRight pad a string to a given length with a specified character (or a space if unspecified):
Console.WriteLine ("12345".PadLeft (9, '*'));  // ****12345
Console.WriteLine ("12345".PadLeft (9));       //     12345

// TrimStart, TrimEnd and Trim remove specified characters (whitespace, by default) from the string:
Console.WriteLine ("  abc \t\r\n ".Trim().Length);   // 3

// Replace replaces all occurrences of a particular character or substring:
Console.WriteLine ("to be done".Replace (" ", " | ") );  // to | be | done
Console.WriteLine ("to be done".Replace (" ", "")    );  // tobedone

