<Query Kind="Program" />

// switch statements may result in cleaner code than multiple if statements:

static void ShowCard (int cardNumber)
{
	switch (cardNumber)
	{
		case 13:
			Console.WriteLine ("King");
		break;
			case 12:
			Console.WriteLine ("Queen");
			break;
		case 11:
			Console.WriteLine ("Jack");
			break;
		case -1:							// Joker is -1.
			goto case 12;					// In this game joker counts as queen.
		default:							// Executes for any other cardNumber.
			Console.WriteLine (cardNumber);
			break;
	}
}

static void Main()
{
	ShowCard (5); ShowCard (11); ShowCard (13);
}