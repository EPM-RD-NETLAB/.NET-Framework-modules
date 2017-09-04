<Query Kind="Program" />

// The && and || operators test for and and or conditions. They are frequently used in
// conjunction with the ! operator, which expresses not:

static bool UseUmbrella (bool rainy, bool sunny, bool windy)
{
	return !windy && (rainy || sunny);
}

static void Main()
{
	UseUmbrella (true, false, false).Dump();	// True
	UseUmbrella (true, true, true).Dump();		// False
}
