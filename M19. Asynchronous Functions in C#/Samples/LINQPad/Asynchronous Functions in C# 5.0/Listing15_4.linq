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
    Task<string> task = ReadFileAsync("garbage file");
    try
    {
        string text = await task;
        Console.WriteLine("File contents: {0}", text);
    }
    catch (IOException e)
    {
        Console.WriteLine("Caught IOException: {0}", e.Message);
    }
}

static async Task<string> ReadFileAsync(string filename)
{
    using (var reader = File.OpenText(filename))
    {
        return await reader.ReadToEndAsync();
    }
}
