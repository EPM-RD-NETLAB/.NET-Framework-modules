<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

static void Main()
{
	var sm = new StateMachine();
	Console.WriteLine(sm.ToString());
	sm.GoToState1();
	Console.WriteLine(sm.ToString());
	sm.GoToState2();
	Console.WriteLine(sm.ToString());
	sm.Stop();
	Console.WriteLine(sm.ToString());
	sm.Reset();
	Console.WriteLine(sm.ToString());
}

class StateMachine
{
	private int state;
	
	public void GoToState1()
	{
		state = 1;
	}

	public void GoToState2()
	{
		state = 2;
	}

	public void Stop()
	{
		state = -1;
	}

	public void Reset()
	{
		state = 0;
	}

	public int State { get { return state; } }
	public string StateString { get { return state < 0 ? "STOPPED" : state == 0 ? "READY" : "STATE" + state; } }

	public override string ToString()
	{
		return "I'm a state machine and my current state is " + StateString;
	}
}