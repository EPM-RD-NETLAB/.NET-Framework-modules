<Query Kind="Program" />

// A common reason to have a nonpublic constructor is to control instance creation via a static method call:

public class Class1
{
	Class1() { }		// Private constructor
	
	public static Class1 Create()
	{
		// Perform custom logic here to create & configure an instance of Class1
		/* ... */
		return new Class1();
	}
}

static void Main()
{
	Class1 c1 = Class1.Create();	// OK
	Class1 c2 = new Class1();		// Error: Will not compile
}