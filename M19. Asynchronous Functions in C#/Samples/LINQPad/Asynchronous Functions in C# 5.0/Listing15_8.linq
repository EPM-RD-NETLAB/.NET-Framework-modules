<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
    var source = new CancellationTokenSource();
    var task = DelayFor30Seconds(source.Token);
    source.CancelAfter(TimeSpan.FromSeconds(1));
    Console.WriteLine("Initial status: {0}", task.Status);
    try
    {
        task.Wait();
    }
    catch (AggregateException e)
    {
        Console.WriteLine("Caught {0}", e.InnerExceptions[0]);
    }
    Console.WriteLine("Final status: {0}", task.Status);
}

static async Task DelayFor30Seconds(CancellationToken token)
{
    Console.WriteLine("Waiting for 30 seconds...");
    await Task.Delay(TimeSpan.FromSeconds(30), token);
}
