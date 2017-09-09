<Query Kind="Program" />

// To test this in LINQPad, run the query then clone the query (Shift+Ctrl+C) and run the copy at the same time.

static void Main()
{
	// Naming a Mutex makes it available computer-wide. Use a name that's
	// unique to your company and application (e.g., include your URL).
	
	using (var mutex = new Mutex (false, "oreilly.com OneAtATimeDemo"))
	{
		// Wait a few seconds if contended, in case another instance
		// of the program is still in the process of shutting down.
	
		if (!mutex.WaitOne (TimeSpan.FromSeconds (3), false))
		{
			Console.WriteLine ("Another instance of the app is running. Bye!");
			return;
		}
		
		RunProgram();
	}
}

static void RunProgram()
{
	Console.WriteLine ("Running. Press Enter to exit");
	Console.ReadLine();
}
