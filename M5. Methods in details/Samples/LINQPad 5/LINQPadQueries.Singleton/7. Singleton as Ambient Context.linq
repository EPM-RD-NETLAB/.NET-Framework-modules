<Query Kind="Program" />

public interface ILogger
{
	void Write();
}
internal class DefaultLogger : ILogger
{
	public void Write() { }
}
public class GlobalLogger
{
	private static ILogger _logger = new DefaultLogger();

	public static ILogger Logger
	{
		get { return _logger; }
		internal set { _logger = value; }
	}
}