<Query Kind="Statements" />

// When more than one value should execute the same code, you can list the common cases sequentially:

int cardNumber = 12;

switch (cardNumber)
{
	case 13:
	case 12:
	case 11:
		Console.WriteLine ("Face card");
		break;
	default:
		Console.WriteLine ("Plain card");
		break;
}