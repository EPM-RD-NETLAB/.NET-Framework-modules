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
    MainAsync().Wait();
}

static async Task MainAsync()
{
    Task<int> task = ComputeLengthAsync(null);
    Console.WriteLine("Fetched the task");
    int length = await task;
    Console.WriteLine("Length: {0}", length);
}

static async Task<int> ComputeLengthAsync(string text)
{
    if (text == null)
    {
        throw new ArgumentNullException("text");
    }
    await Task.Delay(500); // Simulate real asynchronous work
    return text.Length;
}
