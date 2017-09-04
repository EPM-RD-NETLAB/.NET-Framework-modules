<Query Kind="Program" />

// Instead of using object initializers, we could make Bunny’s constructor accept optional parameters.
// This has both pros and cons (see book):

public class Bunny
{
	public string Name;
	public bool LikesCarrots;
	public bool LikesHumans;

	public Bunny (
		string name,
		bool likesCarrots = false,
		bool likesHumans = false)
	{
		Name = name;
		LikesCarrots = likesCarrots;
		LikesHumans = likesHumans; 
	}
}

static void Main()
{		
	Bunny b = new Bunny (
		name: "Bo",
		likesCarrots: true);
	
	b.Dump();
}