<Query Kind="Statements" />

new Thread (() =>
{
	Console.WriteLine ("I'm running on another thread!");
	Console.WriteLine ("This is so easy!");
}).Start();
