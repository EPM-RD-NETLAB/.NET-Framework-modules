<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Second version
//Second version - simple thread-safety
//Unfortunately, performance suffers as a 
//lock is acquired every time the instance is requested
#endregion

public sealed class Singleton
{
	private static Singleton instance = null;
	private static readonly object padlock = new object();

	private Singleton() { }

	public static Singleton Instance
	{
		get
		{
			lock (padlock)
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}
	}
}

void Main(){ }