<Query Kind="Program" />

public static class Program
{
	public static void Main(string[] args)
	{
		var manager = new MailManager();
		var fax = new Fax();
		fax.Register(manager);
		var pager = new Pager();
		pager.Register(manager);
		
		manager.SimulateNewMail("Minsk", "Riga", "Letter");
		
		manager.NewMail = null;
		
		manager.SimulateNewMail("Minsk", "Warszawa", "Letter");
	}
}

#region NewMailEventArgs
internal sealed class NewMailEventArgs : EventArgs
{
	private readonly string mailFrom, mailTo, mailSubject;

	public NewMailEventArgs(string from, string to, string subject)
	{
		mailFrom = from;
		mailTo = to;
		mailSubject = subject;
	}

	public string From { get { return mailFrom; } }
	public string To { get { return mailTo; } }
	public string Subject { get { return mailSubject; } }
}
#endregion

#region MailManager
class MailManager
{
	public EventHandler<NewMailEventArgs> NewMail;

	protected virtual void OnNewMail(object sender, NewMailEventArgs e)
	{
		NewMail?.Invoke(sender, e);
	}

	public void SimulateNewMail(string from, string to, string subject)
	{
		OnNewMail(this, new NewMailEventArgs(from, to, subject));
	}
}
#endregion

#region Listeners
sealed class Fax
{
	public Fax() { }

	public void Register(MailManager mail)
	{
		mail.NewMail += FaxMsg;
	}

	public void Unregister(MailManager mail)
	{
		mail.NewMail -= FaxMsg;
	}

	private void FaxMsg(Object sender, NewMailEventArgs eventArgs)
	{
		Console.WriteLine("Faxing mail message:");
		Console.WriteLine("From = {0}, To = {1}, Subject = {2}", eventArgs.From, eventArgs.To, eventArgs.Subject);
	}
}

class Pager
{
	private void PagerMsg(Object sender, NewMailEventArgs eventArgs)
	{
		Console.WriteLine("Paging mail message:");
		Console.WriteLine("From = {0}, To = {1}, Subject = {2}", eventArgs.From, eventArgs.To, eventArgs.Subject);
	}

	public void Unregister(MailManager mail)
	{
		mail.NewMail -= PagerMsg;
	}

	public void Register(MailManager mail)
	{
		mail.NewMail += PagerMsg;
	}
}
#endregion