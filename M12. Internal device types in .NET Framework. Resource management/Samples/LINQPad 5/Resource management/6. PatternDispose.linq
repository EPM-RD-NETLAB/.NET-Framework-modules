<Query Kind="Program" />

void Main()
{
	//WrappedResource umnamaged = new WrappedResource(new System.IntPtr());
	//umnamaged.Dispose();
	//vs
	using (WrappedResource umnamaged1 = new WrappedResource(new System.IntPtr()))
	{
		"Using:".Dump();
	}
}

public class WrappedResource : IDisposable
{
	private IntPtr _handle;
	private bool _disposed = false;
	
	public WrappedResource(IntPtr handle) 
	{
		_handle = handle; 
	}
	
	public void Dispose() 
	{
		Dispose(true);
		Debug.WriteLine("Uses Dispose!");
		GC.SuppressFinalize(this);
	}
	
	private void Dispose(bool disposing) 
	{
		if (!_disposed) 
		{ 
			CloseHandle(_handle); 
			_handle = IntPtr.Zero;
		}
		_disposed = true; 
	}
	
	~WrappedResource() 
	{
		Debug.WriteLine("Use Dispose!");
		Dispose(false); 
	}
	
	[System.Runtime.InteropServices.DllImport("kernel32")]
	private extern static bool CloseHandle(IntPtr handle); 
}