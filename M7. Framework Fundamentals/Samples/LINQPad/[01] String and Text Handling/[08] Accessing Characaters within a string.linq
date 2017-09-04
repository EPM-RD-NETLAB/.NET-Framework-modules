<Query Kind="Statements" />

string str  = "abcde";
char letter = str[1];        // letter == 'b'

// string also implements IEnumerable<char>, so you can foreach over its characters:
foreach (char c in "123") Console.Write (c + ",");    // 1,2,3,
