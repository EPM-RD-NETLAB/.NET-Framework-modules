<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var test = new Test();
	new Thread (() => { Thread.Sleep(1000); test.SecurityLevel++; test.SecurityLevel.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(2000); test.SecurityLevel++; test.SecurityLevel.Dump(); }).Start();
	new Thread (() => { Thread.Sleep(3000); test.SecurityLevel++; test.SecurityLevel.Dump(); }).Start();
}

class Test
{
	// The same LocalDataStoreSlot object can be used across all threads.
	LocalDataStoreSlot _secSlot = Thread.GetNamedDataSlot ("securityLevel");
	
	// This property has a separate value on each thread.
	public int SecurityLevel
	{
		get
		{
			object data = Thread.GetData (_secSlot);
			return data == null ? 0 : (int) data;    // null == uninitialized
		}
		set 
		{
			Thread.SetData (_secSlot, value);
		}
	}
}
