<Query Kind="Program" />

void Main()
{
	DatabaseLogSaver saver = new DatabaseLogSaver();
	saver.SaveLogEntry(new ExceptionLogEntry());
	saver.SaveLogEntry(new SimpleLogEntry());
}

abstract class LogEntry
{
	public string Message { get; set; }
	//ets.
	public abstract void Accept(ILogEntryVisitor logEntryVisitor);
}

class ExceptionLogEntry : LogEntry
{
	public Exception Exception { get; set; }
	
	public override void Accept(ILogEntryVisitor logEntryVisitor)
	{
		logEntryVisitor.Visit(this);
	}
}

class SimpleLogEntry : LogEntry
{
	public string AdditionalInfo { get; set; }
	
	public override void Accept(ILogEntryVisitor logEntryVisitor)
	{
		logEntryVisitor.Visit(this);
	}
}

interface ILogEntryVisitor
{
	void Visit(ExceptionLogEntry exceptionLogEntry);
	
	void Visit(SimpleLogEntry simpleLogEntry);
}

class DatabaseLogSaver : ILogEntryVisitor
{
	public void SaveLogEntry(LogEntry logEntry)
	{
		logEntry.Accept(this);
	}

	void ILogEntryVisitor.Visit(ExceptionLogEntry exceptionLogEntry)
	{
		SaveException(exceptionLogEntry);
	}

	void ILogEntryVisitor.Visit(SimpleLogEntry simpleLogEntry)
	{
		SaveSimpleLogEntry(simpleLogEntry);
	}

	private void SaveException(ExceptionLogEntry logEntry){ }
	private void SaveSimpleLogEntry(SimpleLogEntry logEntry){ }
}