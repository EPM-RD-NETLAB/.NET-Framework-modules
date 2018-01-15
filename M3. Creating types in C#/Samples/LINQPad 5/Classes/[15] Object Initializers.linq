<Query Kind="Program" />

// Fields or properties can be initialized in a single statement directly after construction:

static void Main()
{
	// Object initialization syntax. Note that we can still specify constructor arguments:
	
	Bunny b1 = new Bunny { Name="Bo", LikesCarrots=true, LikesHumans=false };
	Bunny b2 = new Bunny ("Bo")     { LikesCarrots=true, LikesHumans=false };
	
	b1.Dump(); b2.Dump();
}

public class Bunny
{
	public string Name;
	public bool LikesCarrots;
	public bool LikesHumans;
	
	public Bunny () {}
	public Bunny (string n) { Name = n; }
}
