<Query Kind="Program" />

void Main()
{
	LazyLogDemo lld = new LazyLogDemo();
	lld.Execute();
}

public class LogFile
{
	public LogFile()
	{
		Console.WriteLine("LogFile constructor");
	}

	public void AddToLog(string msg) { }
}

public class LazyLogDemo
{
	//https://msdn.microsoft.com/ru-ru/library/dd642331(v=vs.110).aspx
	private readonly Lazy<LogFile> _lazyLog = new Lazy<LogFile>();

	public LazyLogDemo()
	{
		string msg = string.Empty;
		bool isError = false;

		// Do something

		if (isError) { this._lazyLog.Value.AddToLog(msg); }
	}

	public void Execute()
	{
		string msg = string.Empty;
		bool isError = true;

		// Do something

		if (isError) { this._lazyLog.Value.AddToLog(msg); }
	}
}