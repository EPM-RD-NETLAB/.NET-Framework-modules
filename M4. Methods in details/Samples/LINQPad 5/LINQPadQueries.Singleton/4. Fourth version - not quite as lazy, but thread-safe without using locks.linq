<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Fourth version
// Fourth version - not quite as lazy, but thread-safe without using locks
#endregion

public sealed class Singleton
{
	private static readonly Singleton instance = new Singleton();

	static Singleton() { }

	private Singleton(){ }

	public static Singleton Instance
	{
		get
		{
			return instance;
		}
	}
}

void Main(){ }