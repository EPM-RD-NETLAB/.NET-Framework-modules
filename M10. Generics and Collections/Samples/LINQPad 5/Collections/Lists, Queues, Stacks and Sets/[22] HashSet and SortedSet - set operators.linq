<Query Kind="Statements">
  
</Query>

{
	var letters = new HashSet<char> ("the quick brown fox");
	letters.IntersectWith ("aeiou");
	foreach (char c in letters) Console.Write (c);     // euio
}
Console.WriteLine();
{
	var letters = new HashSet<char> ("the quick brown fox");
	letters.ExceptWith ("aeiou");
	foreach (char c in letters) Console.Write (c);     // th qckbrwnfx
}
Console.WriteLine();
{
	var letters = new HashSet<char> ("the quick brown fox");
	letters.SymmetricExceptWith ("the lazy brown fox");
	foreach (char c in letters) Console.Write (c);     // quicklazy
}
