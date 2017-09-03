<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region First version
// Not thread-safe
// Bad code! Do not use!
#endregion

public sealed class Singleton
{
	private static Singleton instance = null;

	private Singleton() { }

	public static Singleton Instance
	{
		get
		{
			if (instance==null)
			{
				instance = new Singleton();
			}
			return instance;
		}
	}
}

void Main(){ }