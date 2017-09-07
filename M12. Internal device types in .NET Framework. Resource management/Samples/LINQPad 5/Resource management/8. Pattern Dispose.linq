<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Activities.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceModel.Internals.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.DurableInstancing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.VisualBasic.Activities.Compiler.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.VisualBasic.dll</Reference>
  <Namespace>System.Activities</Namespace>
</Query>

class File : IDisposable
{
    Handle handle;

    public File(string filename)
    {
        handle = new SomeHandle(filename);
    }

    public byte[] Read(int bytes)
    {
        Util.InternalRead(handle, bytes);
    }

    ~File()
    {
        Debug.Assert(false, "Use Dispose!");
        handle.Close();
    }

    public void Dispose()
    {
        handle.Close();
        GC.SuppressFinalize(this);
    }
}