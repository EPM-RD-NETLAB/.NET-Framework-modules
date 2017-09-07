<Query Kind="Statements">
  
</Query>

{
	var letters = new HashSet<char> ("the quick brown fox");

	Console.WriteLine (letters.Contains ('t'));      // true
	Console.WriteLine (letters.Contains ('j'));      // false

	foreach (char c in letters) Console.Write (c);   // the quickbrownfx
}
Console.WriteLine();
{
	var letters = new SortedSet<char> ("the quick brown fox");

	foreach (char c in letters) 
		Console.Write (c);                                    //  bcefhiknoqrtuwx
		
	Console.WriteLine();

	foreach (char c in letters.GetViewBetween ('f', 'j'))
		Console.Write (c);                                    //  fhk
}