<Query Kind="Program" />

public delegate void ProgressReporter (int percentComplete);

public class Util
{
	public static void HardWork (ProgressReporter p)
	{
		for (int i = 0; i <= 10; i++)
		{
			p (i * 10);                           // Invoke delegate
			System.Threading.Thread.Sleep (100);  // Simulate hard work
		}
	}
}

static void Main()
{
	ProgressReporter p = WriteProgressToConsole;
	p += WriteProgressToFile;
	Util.HardWork (p);
}

static void WriteProgressToConsole (int percentComplete)
{
	Console.WriteLine (percentComplete);
}

static void WriteProgressToFile (int percentComplete)
{
	System.IO.File.AppendAllText(@"C:\Users\Anzhelika\Desktop\23.03.2012\LINQPad for module 10\progress.txt",string.Format("{0} " + System.Environment.NewLine,percentComplete));
}