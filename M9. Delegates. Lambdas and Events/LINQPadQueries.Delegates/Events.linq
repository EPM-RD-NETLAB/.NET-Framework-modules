<Query Kind="Statements" />

public static class EventHandlerExtensions
{
	public static void SafeRaise(this EventHandler handler, object sender, EventArgs e)
	{
		if (handler != null)//Interlocked!
			handler(sender, e);
	}
	public static void SafeRaise<TEventArgs>(this EventHandler<TEventArgs> handler,
		object sender, TEventArgs e) where TEventArgs : EventArgs
	{
		if (handler != null)
			handler(sender, e);
	}
}

public event EventHandler Changed = delegate { };