<Query Kind="Program" />

//Но ведь по принципу единственности ответственности не SmptMailer 
//отвечает за логирование, почему изменения дошли и до него? 
//Потому что нарушен наш принцип открытости/закрытости. 
//SmptMailer не закрыт для модификации. Нам пришлось его изменить, 
//чтобы поменять способ хранения его логов.

public class DatabaseLogger
{
	public void Log(string logText)
	{
		// сохранить лог в базе данных
	}
}

public class SmtpMailer
{
	private readonly DatabaseLogger logger;//1
	
	public SmtpMailer()
	{
		logger = new DatabaseLogger();//2
	}
	
	public void SendMessage(string message)
	{
		// отсылка сообщения
		logger.Log(string.Format("Отправлено '{0}'", message));
	}
}