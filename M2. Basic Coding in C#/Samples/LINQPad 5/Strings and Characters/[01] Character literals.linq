<Query Kind="Statements" />

// C#’s char type represents a Unicode character and occupies two bytes.

char c = 'A';       // Simple character

// Escape sequences express characters that cannot be expressed or interpreted literally.
// An escape sequence is a backslash followed by a character with a special meaning:

char newLine = '\n';
char backSlash = '\\';

c.Dump();
(backSlash.ToString() + newLine.ToString() + backSlash.ToString()).Dump();