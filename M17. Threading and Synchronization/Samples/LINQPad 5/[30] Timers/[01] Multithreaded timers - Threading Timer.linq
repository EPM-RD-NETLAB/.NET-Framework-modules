<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void Main()
{
	// First interval = 5000ms; subsequent intervals = 1000ms
	Timer tmr = new Timer (Tick, "tick...", 5000, 1000);
	Console.WriteLine ("Press Enter to stop");
	Console.ReadLine();
	tmr.Dispose();         // This both stops the timer and cleans up.
}
	
static void Tick (object data)
{
	// This runs on a pooled thread
	Console.WriteLine (data);          // Writes "tick..."
}
