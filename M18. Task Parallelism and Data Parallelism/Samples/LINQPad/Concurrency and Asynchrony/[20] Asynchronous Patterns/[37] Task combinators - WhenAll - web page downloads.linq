<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	int totalSize = await GetTotalSize ("http://www.linqpad.net http://www.albahari.com http://stackoverflow.com".Split());
	totalSize.Dump();
}

async Task<int> GetTotalSize (string[] uris)
{
	IEnumerable<Task<byte[]>> downloadTasks = uris.Select (uri => new WebClient().DownloadDataTaskAsync (uri));	
	byte[][] contents = await Task.WhenAll (downloadTasks);
	return contents.Sum (c => c.Length);
}
