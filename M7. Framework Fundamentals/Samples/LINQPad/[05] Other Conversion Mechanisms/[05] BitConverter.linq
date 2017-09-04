<Query Kind="Statements" />

foreach (byte b in BitConverter.GetBytes (3.5))
	Console.Write (b + " ");                          // 0 0 0 0 0 0 12 64
