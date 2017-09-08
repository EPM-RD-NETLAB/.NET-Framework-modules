<Query Kind="Program" />

//В данном случае защитить SmtpMailer поможет выделение абстракции.

public interface ILogger
{
	 void Log(string logText);
}
	 
public class Logger : ILogger
{
	public void Log(string logText)
	{
	    // сохранить лог в файле
	}
}
	 
public class DatabaseLogger : ILogger
{
	public void Log(string logText)
	{
	    // сохранить лог в базе данных
	}
}
	 
public class SmtpMailer
{
	private readonly ILogger logger;
	 
	public SmtpMailer(ILogger logger)
	{
	   	this.logger = logger;
	}
	 
	public void SendMessage(string message)
	{
	    // отсылка сообщения
	    logger.Log(string.Format("Отправлено '{0}'", message));
	}
}