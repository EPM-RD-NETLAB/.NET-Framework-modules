<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Fifth version
// Fifth version - fully lazy instantiation
#endregion

public sealed class Singleton
{
	private Singleton(){ }

	public static Singleton Instance { get { return Nested.instance; } }
	
	private class Nested
	{
		internal static readonly Singleton instance = new Singleton();
	}
}

void Main() { }