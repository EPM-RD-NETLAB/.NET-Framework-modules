<Query Kind="Statements" />

bool done = false;
ThreadStart action = () =>
{
	if (!done) { done = true; Console.WriteLine ("Done"); }
};
new Thread (action).Start();
action();
