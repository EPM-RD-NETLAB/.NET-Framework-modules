<Query Kind="Program" />

public static class Program
{
	public static void Main(string[] args)
	{
		var manager = new MailManager();
		var fax = new Fax(manager);
		var pager = new Pager();
		pager.Register(manager);
		//manager.NewMail = null;
		manager.SimulateNewMail("Minsk", "Riga", "Letter");

		//Thread.Sleep(1000);

		fax.Unregister(manager);
		Console.WriteLine();
		manager.SimulateNewMail("Warsawa", "Minsk", "SMS");
	}
}

#region NewMailEventArgs
// Этап 1: определение типа, хранящего информацию,
// которая передается получателям уведомления о событии.
public sealed class NewMailEventArgs : EventArgs
{
	#region fields
	private readonly string mailFrom;
	private readonly string mailTo;
	private readonly string mailSubject;
	#endregion

	#region ctor
	public NewMailEventArgs(string from, string to, string subject)
	{
		mailFrom = from;
		mailTo = to;
		mailSubject = subject;
	}
	#endregion

	#region properties
	public string From { get { return mailFrom; } }
	public string To { get { return mailTo; } }
	public string Subject { get { return mailSubject; } }
	#endregion
}
#endregion

#region MailManager
public class MailManager
{
	//Этап 2. Определение члена-события 
	public event EventHandler<NewMailEventArgs> NewMail = delegate { };// null?

	//Этап 3: Определение метода, ответственного за уведомление зарегистрированных объектов о событии
	//(Для изолированного класса метод будет закрытый и невиртуальный)
	protected virtual void OnNewMail(NewMailEventArgs e)
	{
		//для синхронизации потоков
		EventHandler<NewMailEventArgs> temp = NewMail;//возможна оптимизация компилятора!
		//Потокобезопасный вызов события оставлен на усмотрение разработчиков
		//		if (temp != null)
		//		{
		//			// может быть вызвано исключение NullReferenceException в том случае,
		//			// если обработчик был удален из списка уже после проверки
		//			temp(this, e);
		//		}
		temp?.Invoke(this, e);
	}

	// Этап 4: определение метода, транслирующего входную информацию в желаемое событие
	public void SimulateNewMail(string from, string to, string subject)
	{
		OnNewMail(new NewMailEventArgs(from, to, subject));
	}
}
#endregion

#region Listeners
sealed class Fax
{
	public Fax(MailManager mail)
	{
		mail.NewMail += FaxMsg;
	}

	//MailManager вызывает этот метод для уведомления
	//объекта Fax о прибытии нового почтового сообщени
	private void FaxMsg(object sender, NewMailEventArgs eventArgs)
	{
		Console.WriteLine("Faxing mail message:");
		Console.WriteLine("From = {0}, To = {1}, Subject = {2}", eventArgs.From, eventArgs.To, eventArgs.Subject);
	}

	public void Unregister(MailManager mail)
	{
		mail.NewMail -= FaxMsg;
	}
}

class Pager
{
	public Pager() { }

	//	public Pager(MailManager mail)
	//	{
	//		mail.NewMail += PagerMsg;
	//	}

	public void Register(MailManager mail)
	{
		mail.NewMail += PagerMsg;
	}

	public void Unregister(MailManager mail)
	{
		mail.NewMail -= PagerMsg;
	}

	private void PagerMsg(object sender, NewMailEventArgs eventArgs)
	{
		Console.WriteLine("Paging mail message:");
		Console.WriteLine("From = {0}, To = {1}, Subject = {2}", eventArgs.From, eventArgs.To, eventArgs.Subject);
	}
}
#endregion