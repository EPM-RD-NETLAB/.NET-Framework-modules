<Query Kind="Program" />

// The this reference refers to the instance itself:

public class Panda
{
	public Panda Mate;

	public void Marry (Panda partner)
	{
		Mate = partner;
		partner.Mate = this;
	}
}

static void Main()
{		
	new Panda().Marry (new Panda());
}